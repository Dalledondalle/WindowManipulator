using System.Diagnostics;
using System.Linq;
using WindowManipulator.Library;

namespace WindowManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = new Settings();
            setting.SetFocusWindowSettings(1850, 900);
            foreach (var item in Process.GetProcesses().Where(x => x.ProcessName == "Notepad"))
            {
                setting.AddProcess(item);
            }

            while(true)
            {
                setting.UpdateWindows();
            }
        }
    }
}
