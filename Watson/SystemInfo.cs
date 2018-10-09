using System;

namespace Watson
{
    public class SystemInfo
    {
        public string OsBuild { get; }

        public UInt16 CpuAddrWidth { get; }

        public int ProcIntPtr { get; }

        public string WinPath { get; }

        public int CpuCount { get; }

        private SystemInfo(string osBuild, UInt16 cpuAddrWidth, int procIntPtr, string winPath, int cpuCount)
        {
            OsBuild = osBuild;
            CpuAddrWidth = cpuAddrWidth;
            ProcIntPtr = procIntPtr;
            WinPath = winPath;
            CpuCount = cpuCount;
        }

        public static SystemInfo Collect()
        {
            var osBuild = SystemInfoHelpers.GetOSBuildNumber();

            var cpuAddrWidth = SystemInfoHelpers.GetCPUArchitecutre();

            var procIntPtr = SystemInfoHelpers.GetProcessArchitecture();

            var winPath = SystemInfoHelpers.GetWinPath(cpuAddrWidth, procIntPtr);

            var cpuCount = SystemInfoHelpers.GetProcessorCoreCount();

            return new SystemInfo(osBuild, cpuAddrWidth, procIntPtr, winPath, cpuCount);
        }
    }
}