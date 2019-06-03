using System;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Watson
{
    public class Wmi
    {
        public static List<string> GetInstalledKBs()
        {
            List<string> KbList = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\cimv2", "SELECT HotFixID FROM Win32_QuickFixEngineering");
            ManagementObjectCollection collection = searcher.Get();

            foreach (ManagementObject kb in collection)
            {
                KbList.Add((kb["HotFixID"].ToString()).Remove(0, 2));
            }

            return KbList;
        }

        public static string GetBuildNumber()
        {
            string buildNum = string.Empty;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\cimv2", "SELECT BuildNumber FROM Win32_OperatingSystem");
            ManagementObjectCollection collection = searcher.Get();

            foreach (ManagementObject num in collection)
            {
                buildNum = (string)num["BuildNumber"];
            }

            return buildNum;
        }

        public static uint GetCPUCount()
        {
            uint cpu = 0;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\cimv2", "SELECT NumberofLogicalProcessors FROM Win32_Processor");
            ManagementObjectCollection collection = searcher.Get();

            foreach (ManagementObject num in collection)
            {
                cpu = (uint)num["NumberofLogicalProcessors"];
            }

            return cpu;
        }
    }
}