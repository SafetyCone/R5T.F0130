using System;


namespace R5T.F0130
{
    public static class Instances
    {
        public static F0124.IDirectoryNameOperator DirectoryNameOperator => F0124.DirectoryNameOperator.Instance;
        public static F0000.IFileExtensionOperator FileExtensionOperator { get; } = F0000.FileExtensionOperator.Instance;
        public static Z0072.Z004.IFileExtensions FileExtensions => Z0072.Z004.FileExtensions.Instance;
        public static F0124.IFileNameOperator FileNameOperator => F0124.FileNameOperator.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static IProjectNameConventions ProjectNameConventions => F0130.ProjectNameConventions.Instance;
        public static IProjectPathConventions ProjectPathConventions => F0130.ProjectPathConventions.Instance;
    }
}