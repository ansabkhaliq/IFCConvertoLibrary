using System;
using System.Diagnostics;
using System.IO;

namespace IFCConvertoLibrary
{
    public class IFCConvert
    {
        private static void InstallIfcConvert()
        {
#if bit86
            InstallBinaryFile("IfcConvert32.exe", Properties.Resources.IfcConvert32);
#endif

#if bit64
            InstallBinaryFile("IfcConvert64.exe", Properties.Resources.IfcConvert64);
#endif            
        }

        private static void InstallBinaryFile(string filename, byte[] bytes)
        {
            string path = Path.Combine(IOUtils.AssemblyDirectory, filename);

            if (File.Exists(path))
            {
                return;
            }

            File.WriteAllBytes(path, bytes);
        }

        public static void Convert(string source, string target, Action<string> callback = null)
        {
            InstallIfcConvert();

#if bit86
            string executablePath = Path.Combine(IOUtils.AssemblyDirectory, "IfcConvert32.exe");
#endif

#if bit64
            string executablePath = Path.Combine(IOUtils.AssemblyDirectory, "IfcConvert64.exe");            
#endif

            var info = new ProcessStartInfo();
            info.FileName = string.Format("\"{0}\"", executablePath);
            info.WorkingDirectory = IOUtils.AssemblyDirectory;
            info.Arguments = string.Format("\"{0}\" \"{1}\"", source, target);

            info.RedirectStandardInput = false;
            info.RedirectStandardOutput = true;
            info.UseShellExecute = false;
            info.CreateNoWindow = true;

            using (var proc = new Process())
            {
                proc.StartInfo = info;
                proc.Start();
                string message = proc.StandardOutput.ReadToEnd();

                if (callback != null)
                {
                    callback(message);
                }
                else
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
