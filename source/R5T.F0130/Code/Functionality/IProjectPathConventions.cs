using System;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0187;


namespace R5T.F0130
{
    /// <summary>
    /// Conventions for project-related paths in libraries (like project files are in their own directories, but solution files are all in the same directory).
    /// (Different from project-related path conventions in a project directory, like bin, obj, etc.)
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectPathConventions : IFunctionalityMarker
    {
        public IProjectDirectoryPath Get_ProjectDirectoryPath(
            ISolutionDirectoryPath solutionDirectoryPath,
            IProjectName projectName)
        {
            var projectDirectoryName = Instances.ProjectNameConventions.Get_ProjectDirectoryName(projectName);

            var projectDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                solutionDirectoryPath.Value,
                projectDirectoryName.Value)
                .ToProjectDirectoryPath();

            return projectDirectoryPath;
        }

        public IProjectFilePath Get_ProjectFilePath(
            ISolutionDirectoryPath solutionDirectoryPath,
            IProjectName projectName)
        {
            var projectDirectoryPath = this.Get_ProjectDirectoryPath(
                solutionDirectoryPath,
                projectName);

            var projectFileName = Instances.ProjectNameConventions.Get_ProjectFileName(projectName);

            var projectFilePath = Instances.PathOperator.Get_FilePath(
                projectDirectoryPath.Value,
                projectFileName.Value)
                .ToProjectFilePath();

            return projectFilePath;
        }
    }
}
