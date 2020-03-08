using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinCommonSoftware.Utils {
    public class ProcessManagerUtil {
        private List<Process> _processList = new List<Process> ();
        private static ProcessManagerUtil _instacne = null;
        public static ProcessManagerUtil Instance {
            get {
                if (_instacne == null) {
                    _instacne = new ProcessManagerUtil ();
                }
                return _instacne;
            }
        }
        private ProcessManagerUtil () {
            Console.CancelKeyPress += (s, e) => {
                ProcessManagerUtil.Instance.Dispose ();
            };
            AppDomain.CurrentDomain.ProcessExit += (s, e) => {
                ProcessManagerUtil.Instance.Dispose ();
            };
        }

        public void StartProcessWithoutWindow (string appPath, DataReceivedEventHandler outputDataAction, DataReceivedEventHandler eventHandlerAction, Action<int> processIdHandle) {

            var t = new Thread (() => {
                ProcessStartInfo startInfo = new ProcessStartInfo (appPath);
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true; //重定向输出，而不是默认的显示在dos控制台上
                startInfo.RedirectStandardError = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                try {
                    Process process = Process.Start (startInfo);
                    process.OutputDataReceived += outputDataAction;

                    process.ErrorDataReceived += eventHandlerAction;
                    //当EnableRaisingEvents为true，进程退出时Process会调用下面的委托函数
                    process.Exited += (s, _e) => Console.WriteLine ("Exited with " + process.ExitCode);
                    process.EnableRaisingEvents = true;
                    process.BeginOutputReadLine ();
                    process.BeginErrorReadLine ();
                    processIdHandle.Invoke (process.Id);
                    this._processList.Add (process);
                } catch (Exception ex) {
                    Console.WriteLine (ex.Message);
                }
            });
            t.IsBackground = true;
            t.Start ();
        }

        public void Dispose () {
            this._processList.ForEach (p => {
                if (p != null) {
                    try {
                        p.Kill ();
                        p.CloseMainWindow ();
                        p.Close ();
                    } catch (Exception e) {
                        Console.WriteLine (e);
                    }
                }
            });
        }
    }
}