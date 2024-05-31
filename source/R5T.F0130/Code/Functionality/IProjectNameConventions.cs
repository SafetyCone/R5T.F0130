using System;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0180;
using R5T.T0180.Extensions;
using R5T.T0187;

namespace R5T.F0130
{
    [FunctionalityMarker]
    public partial interface IProjectNameConventions : IFunctionalityMarker
    {
        public IDirectoryName Get_ProjectDirectoryName(IProjectName projectName)
        {
            // The project directory name is just the project name.
            var candidateProjectDirectoryName = projectName.Value;

            // Modified, if required, to be a directory name.
            var output = Instances.DirectoryNameOperator.Ensure_IsValid(candidateProjectDirectoryName)
                .ToDirectoryName();

            return output;
        }

        public IFileNameStem Get_ProjectFileNameStem(IProjectName projectName)
        {
            // The project file name stem is just the project name.
            var candidateProjectFileNameStem = projectName.Value;

            // Modified, if required, to be a file name.
            var output = Instances.FileNameOperator.Ensure_IsValid(candidateProjectFileNameStem)
                .ToFileNameStem();

            return output;
        }

        public IProjectFileName Get_ProjectFileName(IProjectName projectName)
        {
            var projectFileNameStem = this.Get_ProjectFileNameStem(projectName);

            var output = Instances.FileExtensionOperator.Get_FileName(
                projectFileNameStem.Value,
                Instances.FileExtensions.CSharp_ProjectFile.Value)
                .ToProjectFileName();

            return output;
        }
    }
}
