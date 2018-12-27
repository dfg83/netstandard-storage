﻿using System.Collections.Generic;
using System.IO;
using Plugin.NetStandardStorage.Abstractions.Types;

namespace Plugin.NetStandardStorage.Abstractions.Interfaces
{
    /// <summary>
    /// Represents a file. Provides information about the file and its contents,
    /// and ways to manipulate them.
    /// </summary>
    public interface IFile
    {
        /// <summary> The name of the file. </summary>
        string Name { get; }

        /// <summary> The full path of the file. </summary>
        string FullPath { get; }

        /// <summary> Opens a stream with the specified options over the specified file. </summary>
        /// <param name="fileAccess">One of the enumeration values that  specifies the type of access to allow.</param>
        /// <returns>When this method completes, it returns the stream.</returns>
        Stream Open(FileAccess fileAccess);

        /// <summary>
        /// Renames the current file to the specified name.
        /// 
        /// This method also specifies what to do if a file with the
        /// same name already exists in the specified folder.
        /// </summary>
        /// <param name="newName">The new name</param>
        /// <param name="option">The enum value that determines how the platform 
        /// responds if the filename from the *newName* is the same as the name.
        /// of an existing item in the current item's location.</param>
        void Rename(string newName, NameCollisionOption option = NameCollisionOption.FailIfExists);

        /// <summary>
        /// Moves the current file to the specified path.
        /// 
        /// This method also specifies what to do if a file with the
        /// same name already exists in the specified folder.
        /// </summary>
        /// <param name="newPath">The new path</param>
        /// <param name="option">The enum value that determines how the platform 
        /// responds if the filename from the *newPath* is the same as the name.
        /// of an existing item in the current item's location.</param>
        void Move(string newPath, NameCollisionOption option = NameCollisionOption.ReplaceExisting);

        /// <summary>
        /// Deletes the current file.
        /// </summary>
        void Delete();

        /// <summary>
        /// </summary>
        /// <param name="bytes">The bytes to write to the file.</param>
        void WriteAllBytes(byte[] bytes);

        /// <summary> Creates a new file, writes a collection of strings to the file, and then closes the file. </summary>
        /// <param name="contents">The lines to write to the file.</param>
        void WriteAllLines(IEnumerable<string> contents);

        /// <summary>
        /// Creates a new file, writes the specified string to the file, and then closes
        /// the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="contents">The string to write to the file.</param>
        void WriteAllText(string contents);
    }
}
