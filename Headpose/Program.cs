using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RunPythonScript
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // specify the path to the Anaconda environment activation script
            string activateScript = @"C:\Users\RaPIDadmin\anaconda3\Scripts\activate.bat";

            // specify the name of the Anaconda environment
            string environmentName = "py38";

            // specify the path to the Python script that you want to run
            string scriptPath = @"C:\Users\RaPIDadmin\Headpose\Headpose\headpose.py";

            // specify the command to activate the Anaconda environment and run the Python script
            string command = $@"call {activateScript} {environmentName} && python {scriptPath}";

            // start a new process to run the command
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $@"/c ""{command}""";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    Console.WriteLine(e.Data);
                }
            };

            process.Start();
            process.BeginOutputReadLine();

            await process.WaitForExitAsync();

            Console.WriteLine("Python script has finished.");
        }
    }
}

