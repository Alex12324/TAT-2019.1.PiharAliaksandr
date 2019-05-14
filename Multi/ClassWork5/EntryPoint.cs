using System;

namespace ClassWork5
{
    /// <summary>
    /// Entry point class.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Server server = new Server("ftp.planningpme.com/fiches/es");
                server.DownloadAllFiles();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
