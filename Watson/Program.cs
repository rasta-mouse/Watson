using System;
using System.Diagnostics;
using System.Management;
using System.Data;

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

        public static void PrintLogo()
        {
            Console.WriteLine("  __    __      _                   ");
            Console.WriteLine(" / / /\\ \\ \\__ _| |_ ___  ___  _ __  ");
            Console.WriteLine(" \\ \\/  \\/ / _` | __/ __|/ _ \\| '_ \\ ");
            Console.WriteLine("  \\  /\\  / (_| | |_\\__ \\ (_) | | | |");
            Console.WriteLine("   \\/  \\/ \\__,_|\\__|___/\\___/|_| |_|");
            Console.WriteLine("                                   ");
            Console.WriteLine("                           v0.1    ");
            Console.WriteLine("                                   ");
            Console.WriteLine("                  Sherlock sucks...");
            Console.WriteLine("                   @_RastaMouse\r\n");
        }

        public static DataTable GetTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));
            dataTable.Columns.Add("Exploit", typeof(string));
            dataTable.Columns.Add("Vulnerable", typeof(bool));
            dataTable.Columns.Add("Notes", typeof(string));

            dataTable.Rows.Add("MS10-015", "Windows SYSTEM Escalation via KiTrap0D.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms10_015_kitrap0d.rb", false, "None.");
            dataTable.Rows.Add("MS10-073", "Kernel-mode drivers load unspecified keyboard layers improperly, which result in arbitrary code execution in the kernel.", "https://www.exploit-db.com/exploits/36327/", false, "None.");
            dataTable.Rows.Add("MS10-092", "When processing task files, the Windows Task Scheduler only uses a CRC32 checksum to validate that the file has not been tampered with.Also, In a default configuration, normal users can read and write the task files that they have created.By modifying the task file and creating a CRC32 collision, an attacker can execute arbitrary commands with SYSTEM privileges.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms10_092_schelevator.rb", false, "None.");
            //
            dataTable.Rows.Add("MS11-046", "The Ancillary Function Driver (AFD) in afd.sys does not properly validate user-mode input, which allows local users to elevate privileges.", "https://www.exploit-db.com/exploits/40564/", false, "None.");
            dataTable.Rows.Add("MS11-080", "An EoP exists due to a flaw in the AfdJoinLeaf function of the afd.sys driver, allowing data overwrite in kernel space.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms11_080_afdjoinleaf.rb", false, "None.");
            //
            dataTable.Rows.Add("MS12-042", "An EoP exists due to the way the Windows User Mode Scheduler handles system requests, which can be exploited to execute arbitrary code in kernel mode.", "https://www.exploit-db.com/exploits/20861/", false, "None.");
            //
            dataTable.Rows.Add("MS13-005", "Due to a problem with isolating window broadcast messages in the Windows kernel, an attacker can broadcast commands from a lower Integrity Level process to a higher Integrity Level process, thereby effecting a privilege escalation.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms13_005_hwnd_broadcast.rb", false, "None.");
            dataTable.Rows.Add("MS13-053", "An EoP exists due to a kernel pool overflow in Win32k.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms13_053_schlamperei.rb", false, "None.");
            dataTable.Rows.Add("MS13-081", "An EoP exists in win32k.sys where under specific conditions TrackPopupMenuEx will pass a NULL pointer to the MNEndMenuState procedure.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms13_081_track_popup_menu.rb", false, "None.");
            //
            dataTable.Rows.Add("MS14-058", "An EoP exists due to a NULL Pointer Dereference in win32k.sys, triggered through the use of TrackPopupMenu.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms14_058_track_popup_menu.rb", false, "None.");
            //
            dataTable.Rows.Add("MS15-051", "An EoP exists due to improper object handling in the win32k.sys kernel mode driver.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms15_051_client_copy_image.rb", false, "None.");
            dataTable.Rows.Add("MS15-076", "Local DCOM DCE/RPC connections can be reflected back to a listening TCP socket allowing access to an NTLM authentication challenge for LocalSystem, which can be replayed to the local DCOM activation service to elevate privileges.", "https://www.exploit-db.com/exploits/37768/", false, "None.");
            dataTable.Rows.Add("MS15-078", "An EoP exists due to a pool based buffer overflow in the atmfd.dll driver when parsing a malformed font.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms15_078_atmfd_bof.rb", false, "None.");
            //
            dataTable.Rows.Add("MS16-014", "An EoP exists when the Windows kernel improperly handles objects in memory.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms16_014_wmi_recv_notif.rb", false, "None.");
            dataTable.Rows.Add("MS16-016", "An EoP exists in the Microsoft Web Distributed Authoring and Versioning (WebDAV) client when WebDAV improperly validates input.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/ms16_016_webdav.rb", false, "None.");
            dataTable.Rows.Add("MS16-032", "An EoP exists due to a lack of sanitization of standard handles in Windows' Secondary Logon Service.", "https://github.com/FuzzySecurity/PowerShell-Suite/blob/master/Invoke-MS16-032.ps1", false, "None.");
            dataTable.Rows.Add("MS16-034", "An EoP exist when the Windows kernel-mode driver fails to properly handle objects in memory.", "https://github.com/SecWiki/windows-kernel-exploits/tree/master/MS16-034", false, "None.");
            dataTable.Rows.Add("MS16-039", "An EoP exist when the Windows kernel-mode driver fails to properly handle objects in memory.", "https://www.exploit-db.com/exploits/44480/", false, "Exploit is for Windows 7 x86.");
            dataTable.Rows.Add("MS16-072", "This vulnerability allows an attacker to create/modify local Administrator account through a fake Domain Controller by creating User Configuration Group Policies.", "https://www.exploit-db.com/exploits/40219/", false, "Good luck with this one...");
            dataTable.Rows.Add("MS16-111", "The NtLoadKeyEx system call allows an unprivileged user to load registry hives outside of the \\Registry\\A hidden attachment point which can be used to elevate privileges.", "https://www.exploit-db.com/exploits/40429/", false, "None.");
            dataTable.Rows.Add("MS16-123", "The DFS Client driver and running by default insecurely creates and deletes drive letter symbolic links in the current user context, leading to EoP.", "https://www.exploit-db.com/exploits/40572/", false, "Exploit requires weaponisation.");
            dataTable.Rows.Add("MS16-125", "The fix for CVE-2016-3231 is insufficient to prevent a normal user specifying an insecure agent path leading to arbitrary DLL loading at system privileges.", "https://www.exploit-db.com/exploits/40562/", false, "Exploit requires a DLL to load.");
            dataTable.Rows.Add("MS16-135", "An EoP exists when the Windows kernel-mode driver fails to properly handle objects in memory.", "https://github.com/FuzzySecurity/PSKernel-Primitives/tree/master/Sample-Exploits/MS16-135", false, "None.");
            dataTable.Rows.Add("MS16-138", "The VHDMP driver doesn’t safely create files related to Resilient Change Tracking leading to arbitrary file overwrites under user control, leading to EoP.", "https://www.exploit-db.com/exploits/40763/", false, "Exploit requires weaponisation.");
            //
            dataTable.Rows.Add("MS17-012", "When activating an object using the session moniker the DCOM activator doesn’t check if the current user has permission, allowing a user to start an arbitrary process in another logged on user's session.", "https://www.exploit-db.com/exploits/41607/", false, "None.");
            dataTable.Rows.Add("MS17-017", "GDI Palette Objects EoP.", "https://www.exploit-db.com/exploits/42432/", false, "Exploit is for Windows 7 x86 only");
            dataTable.Rows.Add("CVE-2017-0263", "An EoP exists in Windows when the Windows kernel-mode driver fails to properly handle objects in memory.", "https://www.exploit-db.com/exploits/44478/", false, "Exploit is for Windows 7 x86.");
            //
            dataTable.Rows.Add("CVE-2018-8897", "An EoP exists when the Windows kernel fails to properly handle objects in memory.", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/mov_ss.rb", false, "May not work on all hypervisors.");
            dataTable.Rows.Add("CVE-2018-0952", "An EoP exists when Diagnostics Hub Standard Collector allows file creation in arbitrary locations. ", "https://www.exploit-db.com/exploits/45244/", false, "None");
            dataTable.Rows.Add("CVE-2018-8440", "An EoP exists when Windows improperly handles calls to Advanced Local Procedure Call (ALPC).", "https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/alpc_taskscheduler.rb", false, "None.");

            return dataTable;
        }

        public static void UpdateDataTable(string Name, DataTable Table)
        {
            foreach (DataRow row in Table.Rows)
            {
                if ((string) row["Name"] == Name)
                {
                    row["Vulnerable"] = true;
                }
            }
        }

        public static string GetOSBuildNumber()
        {
            string result = string.Empty;

            ManagementObjectSearcher osData = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject os in osData.Get())
            {
                result = os["BuildNumber"].ToString();
            }

            return result;
        }

        public static FileVersionInfo GetFileVersionInfo(string FilePath)
        {
            FileVersionInfo result = FileVersionInfo.GetVersionInfo(FilePath);
            return result;
        }

        public static UInt16 GetCPUArchitecutre()
        {
            // bool result = System.Environment.Is64BitOperatingSystem;  // Not available in .NET <4

            UInt16 result = 0;

            ManagementObjectSearcher cpuData = new ManagementObjectSearcher("select AddressWidth from Win32_Processor");

            foreach (ManagementObject cpu in cpuData.Get())
            {
                result = (UInt16) cpu["AddressWidth"];
            }

            return result;

        }

        public static int GetProcessArchitecture()
        {
            // bool result = System.Environment.Is64BitProcess;  // Not available in .NET <4

            int result = IntPtr.Size;
            return result;
        }

        public static int GetProcessorCoreCount()
        {
            int result = System.Environment.ProcessorCount;
            return result;
        }

        public static string GetWinPath(UInt16 cpuAddrWidth, int procIntPtr)
        {
            if ((cpuAddrWidth == 64 && procIntPtr == 8) || (cpuAddrWidth == 32 && procIntPtr == 4))
            {
                string result = "C:\\WINDOWS\\System32";
                return result;
            }
            else
            {
                string result = "C:\\WINDOWS\\Sysnative";
                return result;
            }

        }

        public static void Main(string[] args)
        {

            PrintLogo();

            // collect some info

            string osBuild = GetOSBuildNumber();
            Console.WriteLine(" [*] OS Build number: {0}", osBuild);

            UInt16 cpuAddrWidth = GetCPUArchitecutre();
            Console.WriteLine(" [*] CPU Address Width: {0}", cpuAddrWidth);

            int procIntPtr = GetProcessArchitecture();
            Console.WriteLine(" [*] Processs IntPtr Size: {0}", procIntPtr);

            string winPath = GetWinPath(cpuAddrWidth, procIntPtr);
            Console.WriteLine(" [*] Using Windows path: {0}", winPath);

            int cpuCount = GetProcessorCoreCount();

            Console.WriteLine();

            // let the fun begin

            DataTable vulnTable = GetTable();

            // ntoskrnl.exe

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\ntoskrnl.exe");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "6000":
                        if (version < 16973) { UpdateDataTable("MS10-015", vulnTable); }
                        break;

                    case "6001":
                        if (version < 18377) { UpdateDataTable("MS10-015", vulnTable); }
                        break;

                    case "6002":
                        if (version < 18160) { UpdateDataTable("MS10-015", vulnTable); }
                        break;

                    case "10240":
                        if (version < 17113) { UpdateDataTable("MS16-111", vulnTable); }
                        if (version < 17184)
                        {
                            UpdateDataTable("MS16-135", vulnTable);
                            UpdateDataTable("MS16-138", vulnTable);
                        }
                        if (version < 17946) { UpdateDataTable("CVE-2018-0952", vulnTable); }
                        if (version < 17976) { UpdateDataTable("CVE-2018-8440", vulnTable); }
                        break;

                    case "10586":
                        if (version < 589) { UpdateDataTable("MS16-111", vulnTable); }
                        if (version < 672)
                        {
                            UpdateDataTable("MS16-135", vulnTable);
                            UpdateDataTable("MS16-138", vulnTable);
                        }
                        break;

                    case "14393":
                        if (version < 953)
                        {
                            UpdateDataTable("MS17-012", vulnTable);
                            UpdateDataTable("MS17-017", vulnTable);
                        }
                        if (version < 1198) { UpdateDataTable("CVE-2017-0263", vulnTable); }
                        if (version < 2248) { UpdateDataTable("CVE-2018-8897", vulnTable); }
                        if (version < 2430) { UpdateDataTable("CVE-2018-0952", vulnTable); }
                        if (version < 2485) { UpdateDataTable("CVE-2018-8440", vulnTable); }
                        break;

                    case "15063":
                        if (version < 296) { UpdateDataTable("CVE-2017-0263", vulnTable); }
                        if (version < 483) { UpdateDataTable("MS16-111", vulnTable); }
                        if (version < 608)
                        {
                            UpdateDataTable("MS16-039", vulnTable);
                            UpdateDataTable("MS16-123", vulnTable);
                        }
                        if (version < 1266) { UpdateDataTable("CVE-2018-0952", vulnTable); }
                        if (version < 1324) { UpdateDataTable("CVE-2018-8440", vulnTable); }
                        break;

                    case "16299":
                        if (version < 611) { UpdateDataTable("CVE-2018-0952", vulnTable); }
                        if (version < 665) { UpdateDataTable("CVE-2018-8440", vulnTable); }
                        break;

                    case "17134":
                        if (version < 48) { UpdateDataTable("CVE-2018-8897", vulnTable); }
                        if (version < 228) { UpdateDataTable("CVE-2018-0952", vulnTable); }
                        if (version < 285) { UpdateDataTable("CVE-2018-8440", vulnTable); }
                        break;
                }
            }
            catch { }

            // win32k.sys

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\win32k.sys");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "6001":
                        if (version < 18523) { UpdateDataTable("MS10-073", vulnTable); }
                        break;

                    case "6002":
                        if (version < 18305) { UpdateDataTable("MS10-073", vulnTable); }
                        if (version < 18739) { UpdateDataTable("MS13-005", vulnTable); }
                        if (version < 18974) { UpdateDataTable("MS13-101", vulnTable); }
                        if (version < 19372) { UpdateDataTable("MS15-051", vulnTable); }
                        if (version < 19597) { UpdateDataTable("MS16-034", vulnTable); }
                        break;

                    case "7600":
                        if (version < 16667) { UpdateDataTable("MS10-073", vulnTable); }
                        if (version < 17017) { UpdateDataTable("MS12-042", vulnTable); }
                        if (version < 17175) { UpdateDataTable("MS13-005", vulnTable); }
                        break;

                    case "9200":
                        if (version < 16468) { UpdateDataTable("MS13-005", vulnTable); }
                        if (version < 16758) { UpdateDataTable("MS13-101", vulnTable); }
                        if (version < 17130) { UpdateDataTable("MS14-058", vulnTable); }
                        if (version < 17343) { UpdateDataTable("MS15-051", vulnTable); }
                        break;

                    case "9600":
                        if (version < 16457) { UpdateDataTable("MS13-101", vulnTable); }
                        if (version < 17796) { UpdateDataTable("MS15-051", vulnTable); }
                        if (version < 17353) { UpdateDataTable("MS14-058", vulnTable); }
                        if (version < 18228) { UpdateDataTable("MS16-034", vulnTable); }
                        break;
                }
            }
            catch { }

            // winsrv.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\winsrv.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "6001":
                        if (version < 18638) { UpdateDataTable("MS11-056", vulnTable); }
                        break;

                    case "6002":
                        if (version < 18456) { UpdateDataTable("MS11-056", vulnTable); }
                        break;

                    case "7600":
                        if (version < 16816) { UpdateDataTable("MS11-056", vulnTable); }
                        break;
                }
            }
            catch { }


            // afd.sys

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\drivers\\afd.sys");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "6001":
                        if (version < 18639) { UpdateDataTable("MS11-046", vulnTable); }
                        break;

                    case "6002":
                        if (version < 18457) { UpdateDataTable("MS11-046", vulnTable); }
                        break;

                    case "7600":
                        if (version < 16802) { UpdateDataTable("MS11-046", vulnTable); }
                        break;
                }
            }
            catch { }

            // schedsvc.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\schedsvc.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "6001":
                        if (version < 18551) { UpdateDataTable("MS10-092", vulnTable); }
                        break;

                    case "6002":
                        if (version < 18342) { UpdateDataTable("MS10-092", vulnTable); }
                        break;

                    case "7600":
                        if (version < 16699) { UpdateDataTable("MS10-092", vulnTable); }
                        break;
                }
            }
            catch { }

            // seclogon.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\seclogon.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "6002":
                        if (version < 19598 && cpuCount > 1) { UpdateDataTable("MS16-032", vulnTable); }
                        break;

                    case "9600":
                        if (version < 18230 && cpuCount > 1) { UpdateDataTable("MS16-032", vulnTable); }
                        break;

                    case "10240":
                        if (version < 16724 && cpuCount > 1) { UpdateDataTable("MS16-032", vulnTable); }
                        break;

                    case "10586":
                        if (version < 162 && cpuCount > 1) { UpdateDataTable("MS16-032", vulnTable); }
                        break;
                }
            }
            catch { }

            // mrxdav.sys

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\drivers\\mrxdav.sys");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "6002":
                        if (version < 19576) { UpdateDataTable("MS16-016", vulnTable); }
                        break;

                    case "9600":
                        if (version < 18189) { UpdateDataTable("MS16-016", vulnTable); }
                        break;

                    case "10240":
                        if (version < 16683) { UpdateDataTable("MS16-016", vulnTable); }
                        break;

                    case "10586":
                        if (version < 103) { UpdateDataTable("MS16-016", vulnTable); }
                        break;
                }
            }
            catch { }

            // rpcrt4.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\rpcrt4.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "6002":
                        if (version < 19431) { UpdateDataTable("MS15-076", vulnTable); }
                        break;

                    case "9200":
                        if (version < 17422) { UpdateDataTable("MS15-076", vulnTable); }
                        break;

                    case "9600":
                        if (version < 17919) { UpdateDataTable("MS15-076", vulnTable); }
                        break;
                }
            }
            catch { }

            // atmfd.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\atmfd.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "9200":
                        if (version < 243) { UpdateDataTable("MS15-078", vulnTable); }
                        break;

                    case "9600":
                        if (version < 243) { UpdateDataTable("MS15-078", vulnTable); }
                        break;
                }
            }
            catch { }

            // winload.exe

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\winload.exe");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "16299":
                        if (version < 431) { UpdateDataTable("CVE-2018-8897", vulnTable); }
                        break;
                }
            }
            catch { }

            // win32kfull.sys

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\win32kfull.sys");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "10240":
                        if (version < 16683) { UpdateDataTable("MS16-014", vulnTable); }
                        if (version < 16724) { UpdateDataTable("MS16-034", vulnTable); }
                        if (version < 16771) { UpdateDataTable("MS16-039", vulnTable); }
                        break;

                    case "10586":
                        if (version < 103) { UpdateDataTable("MS16-014", vulnTable); }
                        if (version < 162) { UpdateDataTable("MS16-034", vulnTable); }
                        if (version < 212) { UpdateDataTable("MS16-039", vulnTable); }
                        break;
                }
            }
            catch { }

            // gdi32.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\gdi32.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "10240":
                        if (version < 17319)
                        {
                            UpdateDataTable("MS17-012", vulnTable);
                            UpdateDataTable("MS17-017", vulnTable);
                        }
                        if (version < 17394) { UpdateDataTable("CVE-2017-0263", vulnTable); }
                        break;

                    case "10586":
                        if (version < 839)
                        {
                            UpdateDataTable("MS17-012", vulnTable);
                            UpdateDataTable("MS17-017", vulnTable);
                        }
                        if (version < 916) { UpdateDataTable("CVE-2017-0263", vulnTable); }
                        break;
                }
            }
            catch { }

            // gdiplus.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\gdiplus.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "10240":
                        if (version < 17146)
                        {
                            UpdateDataTable("MS16-101", vulnTable);
                            UpdateDataTable("MS16-123", vulnTable);
                            UpdateDataTable("MS16-125", vulnTable);
                        }
                        break;

                    case "10586":
                        if (version < 633)
                        {
                            UpdateDataTable("MS16-101", vulnTable);
                            UpdateDataTable("MS16-123", vulnTable);
                            UpdateDataTable("MS16-125", vulnTable);
                        }
                        break;
                }
            }
            catch { }

            // gpprefcl.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\gpprefcl.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "10240":
                        if (version < 16942) { UpdateDataTable("MS16-072", vulnTable); }
                        break;

                    case "10586":
                        if (version < 420) { UpdateDataTable("MS16-072", vulnTable); }
                        break;
                }
            }
            catch { }

            // pcadm.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\pcadm.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "10240":
                        if (version < 17861) { UpdateDataTable("CVE-2018-8897", vulnTable); }
                        break;
                }
            }
            catch { }

            // coremessaging.dll

            try
            {
                FileVersionInfo FileInfo = GetFileVersionInfo(winPath + "\\coremessaging.dll");
                int version = FileInfo.ProductPrivatePart;

                switch (osBuild)
                {
                    case "15063":
                        if (version < 1088) { UpdateDataTable("CVE-2018-8897", vulnTable); }
                        break;
                }
            }
            catch { }

            // and we're done... print results

            int vulnCount = 0;

            foreach (DataRow row in vulnTable.Rows)
            {

                if (row["Vulnerable"].ToString().Equals("True"))  // not sure if you have to do it like this...
                {
                    Console.WriteLine("  [*] Appears vulnerable to {0}", row["Name"]);
                    Console.WriteLine("   [>] Description: {0}", row["Description"]);
                    Console.WriteLine("   [>] Exploit: {0}", row["Exploit"]);
                    Console.WriteLine("   [>] Notes: {0}", row["Notes"]);
                    Console.WriteLine();

                    vulnCount++;
                }
            }

            if (vulnCount > 0)
            {
                Console.WriteLine(" [*] Finished. Found {0} vulns :)", vulnCount);
            }
            else
            {
                Console.WriteLine(" [*] Finished. Sorry, found {0} vulns :(", vulnCount);
            }
        }
    }
}
