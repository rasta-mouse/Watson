using System;
using System.Diagnostics;
using System.Management;

namespace Watson
{
    public static class SystemInfoHelpers
    {
        public static void PrintInfo(SystemInfo systemInfo)
        {
            Console.WriteLine(" [*] OS Build number: {0}", systemInfo.OsBuild);
            Console.WriteLine(" [*] CPU Address Width: {0}", systemInfo.CpuAddrWidth);
            Console.WriteLine(" [*] Process IntPtr Size: {0}", systemInfo.ProcIntPtr);
            Console.WriteLine(" [*] Using Windows path: {0}", systemInfo.WinPath);
        }

        public static string GetOSBuildNumber()
        {
            var result = String.Empty;

            var osData = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject os in osData.Get())
            {
                result = os["BuildNumber"].ToString();
            }

            return result;
        }

        public static int GetFileVersionInfoProductPrivatePart(string filePath) 
            => FileVersionInfo.GetVersionInfo(filePath).ProductPrivatePart;

        public static UInt16 GetCPUArchitecutre()
        {
            // bool result = System.Environment.Is64BitOperatingSystem;  // Not available in .NET <4

            UInt16 result = 0;

            var cpuData = new ManagementObjectSearcher("select AddressWidth from Win32_Processor");

            foreach (ManagementObject cpu in cpuData.Get())
            {
                result = (UInt16)cpu["AddressWidth"];
            }

            return result;

        }

        public static int GetProcessArchitecture()
        {
            // bool result = System.Environment.Is64BitProcess;  // Not available in .NET <4

            return IntPtr.Size;
        }

        public static int GetProcessorCoreCount() 
            => Environment.ProcessorCount;

        public static string GetWinPath(UInt16 cpuAddrWidth, int procIntPtr)
        {
            if ((cpuAddrWidth == 64 && procIntPtr == 8) || (cpuAddrWidth == 32 && procIntPtr == 4))
            {
                return "C:\\WINDOWS\\System32";
            }
            else
            {
                return "C:\\WINDOWS\\Sysnative";
            }

        }
    }
}