using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevPCBase.Utils
{
    public class ProcessManagerUtil : SingletonObject<ProcessManagerUtil>
    {
        public void StartProcessWithoutWindow(string appPath, DataReceivedEventHandler outputDataAction,DataReceivedEventHandler eventHandlerAction,Action<int> processIdHandle)
        {

            var t = new Thread(() =>
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(appPath);
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true; //重定向输出，而不是默认的显示在dos控制台上
                startInfo.RedirectStandardError = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                try
                {
                    Process process = Process.Start(startInfo);
                    process.OutputDataReceived += outputDataAction;

                    process.ErrorDataReceived += eventHandlerAction;
                    //当EnableRaisingEvents为true，进程退出时Process会调用下面的委托函数
                    process.Exited += (s, _e) => Console.WriteLine("Exited with " + process.ExitCode);
                    process.EnableRaisingEvents = true;
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    processIdHandle.Invoke(process.Id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });
            t.IsBackground = true;
            t.Start();
        }
    }
}
