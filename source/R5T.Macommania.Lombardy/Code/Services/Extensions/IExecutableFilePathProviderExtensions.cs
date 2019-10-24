using System;

using R5T.Lombardy;


namespace R5T.Macommania.Lombardy.Extensions
{
    public static class IExecutableFilePathProviderExtensions
    {
        /// <summary>
        /// Get the path of the directory containing the executable file.
        /// </summary>
        public static string GetExecutableFileDirectoryPath(this IExecutableFilePathProvider executableFilePathProvider, IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            var executableFilePath = executableFilePathProvider.GetExecutableFileDirectoryPath();

            var executableFileDirectoryPath = stringlyTypedPathOperator.GetDirectoryPathForFilePath(executableFilePath);
            return executableFileDirectoryPath;
        }
    }
}
