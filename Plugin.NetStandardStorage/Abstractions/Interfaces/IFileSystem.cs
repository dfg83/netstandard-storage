﻿
namespace Plugin.NetStandardStorage.Abstractions.Interfaces
{
    /// <summary>
    /// Provides access to the application data store. Application data consists of files
    /// and settings that are either local or roaming.
    /// </summary>
    public interface IFileSystem
    {
        /// <summary>
        /// Gets the root folder in the local app data store.
        /// </summary>
        IFolder LocalStorage { get; }

        /// <summary>
        /// Gets the root folder in the roaming app data store.
        /// </summary>
        IFolder RoamingStorage { get; }

        /// <summary>
        /// Gets the file from the specified path.
        /// </summary>
        /// <param name="path">The path</param>
        IFile GetFileFromPath(string path);

        /// <summary>
        /// Gets the folder from the specified path.
        /// </summary>
        /// <param name="path">The path</param>
        IFolder GetFolderFromPath(string path);
    }
}
