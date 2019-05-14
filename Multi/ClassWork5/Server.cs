using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork5
{
    /// <summary>
    /// Class server.
    /// </summary>
    class Server
    {
        private string Request { get; set; }

        /// <summary>
        /// Сlass constructor.
        /// </summary>
        /// <param name="request"></param>
        public Server(string request)
        {
            this.Request = request;
        }

        /// <summary>
        /// The method download all files from folder.
        /// </summary>
        public void DownloadAllFiles()
        {
            List<string> files = GetFileList().ToList();
            int length = files.Count; 
            Task[] tasks = new Task[length];
            for (int i = 0; i < length; i++)
            {
                tasks[i] = new Task(Download, files[i]);
            }

            foreach (var task in tasks)
            {
                task.Start();
            }

            Task.WaitAll(tasks);
        }

        /// <summary>
        /// Get files from a folder into a array;
        /// </summary>
        /// <returns></returns>
        public string[] GetFileList()
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            WebResponse response = null;
            StreamReader reader = null;
            try
            {
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + Request + "/"));
                reqFTP.UseBinary = true;
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                reqFTP.Proxy = null;
                reqFTP.KeepAlive = false;
                reqFTP.UsePassive = false;
                response = reqFTP.GetResponse();
                reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
                downloadFiles = null;
                return downloadFiles;
            }
        }

        /// <summary>
        /// The method implements file loading
        /// </summary>
        /// <param name="t_file"></param>
        private void Download(object t_file)
        {
            try
            {
                string file = t_file.ToString();
                string uri = "ftp://" + Request + "/" + file;
                Uri serverUri = new Uri(uri);
                if (serverUri.Scheme != Uri.UriSchemeFtp)
                {
                    return;
                }
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + Request + "/" + file));
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Proxy = null;
                reqFTP.UsePassive = false;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                using (FileStream writeStream = new FileStream((string)file, FileMode.Create))
                {
                    int Length = 2048;
                    Byte[] buffer = new Byte[Length];
                    int bytesRead = responseStream.Read(buffer, 0, Length);
                    while (bytesRead > 0)
                    {
                        writeStream.Write(buffer, 0, bytesRead);
                        bytesRead = responseStream.Read(buffer, 0, Length);
                    }
                }             
                reader.Close();
                response.Close();
            }
            catch (WebException wEx)
            {
                Console.WriteLine(wEx.Message, "Download Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Download Error");
            }
        }
    }
}
