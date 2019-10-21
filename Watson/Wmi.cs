using System;
using System.Management;
using System.Collections.Generic;

namespace Watson
{
    public class Wmi
    {
        public static List<string> GetInstalledKBs()
        {
            List<string> KbList = new List<string>();

            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\cimv2", "SELECT HotFixID FROM Win32_QuickFixEngineering"))
                {
                    ManagementObjectCollection collection = searcher.Get();

                    foreach (ManagementObject kb in collection)
                    {
                        KbList.Add(kb["HotFixID"].ToString().Remove(0, 2));
                    }
                }   
            }
            catch (ManagementException e)
            {
                Console.Error.WriteLine(" [!] {0}", e.Message);
            }

            return KbList;
        }

        public static string GetBuildNumber()
        {
            string buildNum = string.Empty;

            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\cimv2", "SELECT BuildNumber FROM Win32_OperatingSystem"))
                {
                    ManagementObjectCollection collection = searcher.Get();

                    foreach (ManagementObject num in collection)
                    {
                        buildNum = (string)num["BuildNumber"];
                    }
                }
            }
            catch (ManagementException e)
            {
                Console.Error.WriteLine(" [!] {0}", e.Message);
            }

            return buildNum;
        }
    }
}