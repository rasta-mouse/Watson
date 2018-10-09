using System;
using Watson.SuspectFiles;


/*
 * 
 * Build References
 * 
 * [3790:    2003, 2003 R2 & XP]
 * 6000:    Vista
 * 6001:    2008
 * 6002:    2008 SP2 & Vista SP2
 * 7600:    2008 R2 & 7
 * 9200:    2012 & 8
 * 9600:    2012 R2 & 8.1
 * 10240:   10 1507
 * 10586:   10 1511
 * 14393:   2016 & 10 1607
 * 15063:   10 1703
 * 16299:   10 1709
 * 17134:   10 1803
 *     ?:   10 1809
 * 
 */

namespace Watson
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Info.PrintLogo();

            var sysInfo = SystemInfo.Collect();
            SystemInfoHelpers.PrintInfo(sysInfo);

            Console.WriteLine();

            // let the fun begin

            var vulnerabilities = new VulnerabilityCollection();

            // ntoskrnl.exe
            NtoskrnlExe.Check(vulnerabilities, sysInfo);

            // win32k.sys
            Win32kSys.Check(vulnerabilities, sysInfo);

            // winsrv.dll
            WinsrvDll.Check(vulnerabilities, sysInfo);

            // afd.sys
            AfdSys.Check(vulnerabilities, sysInfo);

            // schedsvc.dll
            SchedsvcDll.Check(vulnerabilities, sysInfo);

            // seclogon.dll
            SeclogonDll.Check(vulnerabilities, sysInfo);

            // mrxdav.sys
            MrxdavSys.Check(vulnerabilities, sysInfo);

            // rpcrt4.dll
            Rpcrt4Dll.Check(vulnerabilities, sysInfo);

            // atmfd.dll
            AtmfdDll.Check(vulnerabilities, sysInfo);

            // winload.exe
            WinloadExe.Check(vulnerabilities, sysInfo);

            // win32kfull.sys
            Win32kfullSys.Check(vulnerabilities, sysInfo);

            // gdi32.dll
            Gdi32Dll.Check(vulnerabilities, sysInfo);

            // gdiplus.dll
            GdiplusDll.Check(vulnerabilities, sysInfo);

            // gpprefcl.dll
            GpprefclDll.Check(vulnerabilities, sysInfo);

            // pcadm.dll
            PcadmDll.Check(vulnerabilities, sysInfo);

            // coremessaging.dll
            CoremessagingDll.Check(vulnerabilities, sysInfo);

            // and we're done... print results
            vulnerabilities.ShowResults();
        }
    }
}
