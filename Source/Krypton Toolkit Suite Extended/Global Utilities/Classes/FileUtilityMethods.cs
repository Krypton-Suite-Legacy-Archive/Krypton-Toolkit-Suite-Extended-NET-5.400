﻿using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Core.Classes
{
    /// <summary>
    /// This class is used to retrieve data for the downloaded file.
    /// Version: 1.0
    /// Date: Thursday 31st December 2015
    /// </summary>
    public class FileUtilityMethods
    {
        //GlobalMethods globalMethods = new GlobalMethods();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUtilityMethods"/> class.
        /// </summary>
        public FileUtilityMethods()
        {

        }

        /// <summary>
        /// Parses the size of the readable file.
        /// </summary>
        /// <param name="fileSize">Size of the file.</param>
        /// <returns></returns>
        public static string ParseReadableFileSize(long fileSize)
        {
            string sign = (fileSize < 0 ? "-" : ""), suffix;

            double readable = (fileSize < 0 ? -fileSize : fileSize);

            if (fileSize >= 0x40000000) // Gigabyte
            {
                suffix = "GB";

                readable = (double)(fileSize >> 20);
            }
            else if (fileSize >= 0x100000) // Megabyte
            {
                suffix = "MB";

                readable = (double)(fileSize >> 10);
            }
            else if (fileSize >= 0x400) // Kilobyte
            {
                suffix = "KB";

                readable = (double)fileSize;
            }
            else
            {
                return fileSize.ToString(sign + "0 B"); // Byte
            }

            readable = readable / 1024;

            return sign + readable.ToString("0.### ") + suffix;
        }

        /// <summary>
        /// Parses the size of the readable file.
        /// </summary>
        /// <param name="fileSize">Size of the file.</param>
        /// <returns></returns>
        public string ParseReadableFileSize(int fileSize)
        {
            string output;

            decimal size;

            if (fileSize >= 1073741824)
            {
                size = decimal.Divide(fileSize, 1073741824);

                output = string.Format("{0:##.##} GB", size);
            }
            else if (fileSize >= 1048576)
            {
                size = decimal.Divide(fileSize, 1048576);

                output = string.Format("{0:##.##} MB", size);
            }
            else if (fileSize >= 1024)
            {
                size = decimal.Divide(fileSize, 1024);

                output = output = string.Format("{0:##.##} KB", size);
            }
            else if (fileSize > 0 & fileSize < 1024)
            {
                size = fileSize;

                output = output = string.Format("{0:##.##} Bytes", size);
            }
            else
            {
                output = "Zero Byte File";
            }

            return output;
        }

        /// <summary>
        /// Returns the size of the online file.
        /// </summary>
        /// <param name="onlineFileURL">The online file URL.</param>
        /// <param name="fileSize">Size of the file.</param>
        public void ReturnOnlineFileSize(string onlineFileURL, Label fileSize)
        {
            string URL = onlineFileURL, fileType = URL.Substring(URL.LastIndexOf(".") + 1, (URL.Length - URL.LastIndexOf(".") - 1)), fileName = URL.Substring(URL.LastIndexOf("/") + 1, (URL.Length - URL.LastIndexOf("/") - 1));

            WebRequest request = (HttpWebRequest)WebRequest.Create(onlineFileURL);

            request.Method = "HEAD";

            WebResponse response = (HttpWebResponse)request.GetResponse();

            long contentLength = 0, result;

            if (long.TryParse(response.Headers.Get("Content-Length"), out contentLength))
            {
                if (contentLength >= 1073741824)
                {
                    result = contentLength / 1073741824;

                    fileSize.Text = string.Format("Package Size: {0:##.##} GB", result);
                }
                else if (contentLength >= 1048576)
                {
                    result = contentLength / 1048576;

                    fileSize.Text = string.Format("Package Size: {0:##.##} MB", result);
                }
                else if (contentLength >= 1024)
                {
                    result = contentLength / 1024;

                    fileSize.Text = string.Format("Package Size: {0:##.##} KB", result);
                }
                else
                {
                    result = contentLength;

                    fileSize.Text = string.Format("Package Size: {0:##:##} Bytes", result);
                }
            }
        }

        /// <summary>
        /// Formats the length of the file.
        /// </summary>
        /// <param name="FilePath">The file path.</param>
        /// <param name="Output">The output.</param>
        public void FormatFileLength(string FilePath, Label Output)
        {
            long fileSize = (long)ReturnFileLength(FilePath), result;

            if (fileSize >= 1073741824)
            {
                result = fileSize / 1073741824;

                Output.Text = string.Format("File Size: {0:##:##} GB", result);
            }
            else if (fileSize >= 1048576)
            {
                result = fileSize / 1048576;

                Output.Text = string.Format("File Size: {0:##:##} MB", result);
            }
            else if (fileSize >= 1024)
            {
                result = fileSize / 1024;

                Output.Text = string.Format("File Size: {0:##:##} KB", result);
            }
        }

        /// <summary>
        /// Retrieves the file length from the specified file.
        /// </summary>
        /// <param name="FilePath">The file path to the specified file.</param>
        /// <returns>The file length from the specified file.</returns>
        public int ReturnFileLength(string FilePath)
        {
            return Convert.ToInt32(ReturnFileInformation(FilePath).Length);
        }

        /// <summary>
        /// Retrieves the file last accessed time from the specified file.
        /// </summary>
        /// <param name="FilePath">The file path to the specified file.</param>
        /// <returns>The file last accessed time from the specified file.</returns>
        public DateTime ReturnFileLastAccessedTime(string FilePath)
        {
            return ReturnFileInformation(FilePath).LastAccessTime;
        }

        /// <summary>
        /// Retrieves the file creation time from the specified file.
        /// </summary>
        /// <param name="FilePath">The file path to the specified file.</param>
        /// <returns>The file creation time from the specified file.</returns>
        public DateTime ReturnFileCreationTime(string FilePath)
        {
            return ReturnFileInformation(FilePath).CreationTime;
        }

        /// <summary>
        /// Retrieves the file last write time from the specified file.
        /// </summary>
        /// <param name="FilePath">The file path to the specified file.</param>
        /// <returns>The file last write time from the specified file.</returns>
        public DateTime ReturnFileLastWriteTime(string FilePath)
        {
            return ReturnFileInformation(FilePath).LastWriteTime;
        }

        /// <summary>
        /// Retrieves the file name from the specified file.
        /// </summary>
        /// <param name="FilePath">The file path to the specified file.</param>
        /// <returns>The file name from the specified file.</returns>
        public string ReturnFileName(string FilePath)
        {
            return ReturnFileInformation(FilePath).Name;
        }

        /// <summary>
        /// Retrieves the file extension from the specified file.
        /// </summary>
        /// <param name="FilePath">The file path to the specified file.</param>
        /// <returns>The file extension from the specified file.</returns>
        public string ReturnFileExtension(string FilePath)
        {
            return ReturnFileInformation(FilePath).Extension;
        }

        /// <summary>
        /// Retrieves the file information from the specified file.
        /// </summary>
        /// <param name="FilePath">The file path to the specified file.</param>
        /// <returns>The file information from the specified file.</returns>
        public FileInfo ReturnFileInformation(string FilePath)
        {
            FileInfo fileInformation = new FileInfo(FilePath);

            return fileInformation;
        }

        /// <summary>
        /// Loads from file.
        /// </summary>
        /// <param name="FilePath">The file path.</param>
        /// <returns></returns>
        public string LoadFromFile(string FilePath)
        {
            string fileContent = string.Empty;

            try
            {
                if (new FileInfo(FilePath).Length == 0)
                {
                    MessageBox.Show("The file specified is a zero-byte file. Please try again.", "Zero-Byte File Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fileContent = File.OpenRead(FilePath).ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "Exception Handler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return fileContent;
        }

        /// <summary>
        /// Determines whether [is file locked] [the specified file].
        /// </summary>
        /// <param name="File">The file.</param>
        /// <returns>
        ///   <c>true</c> if [is file locked] [the specified file]; otherwise, <c>false</c>.
        /// </returns>
        protected virtual bool IsFileLocked(FileInfo File)
        {
            FileStream fs = null;

            try
            {
                fs = File.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            return false;
        }

        /// <summary>
        /// Returns the file information on the selected file.
        /// </summary>
        /// <param name="FilePath">The file path.</param>
        /// <returns>Returns the file information on the selected file.</returns>
        public FileInfo ReturnFileInformationOn(string FilePath)
        {
            return new FileInfo(FilePath);
        }

        ~FileUtilityMethods()
        {
            GC.SuppressFinalize(this);
        }
    }
}