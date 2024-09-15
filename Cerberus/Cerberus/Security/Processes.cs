using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerberus.Cerberus.Security
{
    public static class Processes
    {
        private static readonly int[] PidsToKill = { 11460, 23328, 17532, 10556 };
        private static readonly string[] ProcessNamesToKill =
        {
            "ida64", "dnspy", "windbg", "ollydbg", "ida", "idag", "idag64",
            "idaw", "idaw64", "idaq", "idaq64", "idau", "idau64", "scylla",
            "scylla_x64", "scylla_x86", "protection_id", "x32dbg", "x64dbg",
            "reshacker", "ImportREC", "IMMUNITYDEBUGGER", "MegaDumper", "notepad"
        };

        public static void Pulse()
        {
            StartTimer(PID, 2500);
            StartTimer(NAME, 2500);
        }

        private static void StartTimer(Action action, int interval)
        {
            var timer = new System.Timers.Timer(interval);
            timer.Elapsed += (sender, args) => action();
            timer.Start();
        }

        private static void PID()
        {
            foreach (var pid in PidsToKill)
            {
                TryKillProcessById(pid);
            }
        }

        private static void NAME()
        {
            foreach (var processName in ProcessNamesToKill)
            {
                TryKillProcessByName(processName);
            }
        }

        private static void TryKillProcessById(int pid)
        {
            try
            {
                Process.GetProcessById(pid).Kill();
            }
            catch (Exception ex)
            {
                // Log exception or handle it appropriately
                Debug.WriteLine($"Failed to kill process with PID {pid}: {ex.Message}");
            }
        }

        private static void TryKillProcessByName(string processName)
        {
            try
            {
                var processes = Process.GetProcessesByName(processName);
                foreach (var process in processes)
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                // Log exception or handle it appropriately
                Debug.WriteLine($"Failed to kill process with name {processName}: {ex.Message}");
            }
        }
    }
}
