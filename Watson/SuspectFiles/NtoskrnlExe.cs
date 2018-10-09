using System;

namespace Watson.SuspectFiles
{
    internal static class NtoskrnlExe
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\ntoskrnl.exe");

                switch (sysInfo.OsBuild)
                {
                    case "6000":
                        if (version < 16973)
                        {
                            vulnerabilities.SetAsVulnerable("MS10-015");
                        }
                        break;

                    case "6001":
                        if (version < 18377)
                        {
                            vulnerabilities.SetAsVulnerable("MS10-015");
                        }
                        break;

                    case "6002":
                        if (version < 18160)
                        {
                            vulnerabilities.SetAsVulnerable("MS10-015");
                        }
                        break;

                    case "10240":
                        if (version < 17113)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-111");
                        }
                        if (version < 17184)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-135");
                            vulnerabilities.SetAsVulnerable("MS16-138");
                        }
                        if (version < 17946)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-0952");
                        }
                        if (version < 17976)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-8440");
                        }
                        break;

                    case "10586":
                        if (version < 589)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-111");
                        }
                        if (version < 672)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-135");
                            vulnerabilities.SetAsVulnerable("MS16-138");
                        }
                        break;

                    case "14393":
                        if (version < 953)
                        {
                            vulnerabilities.SetAsVulnerable("MS17-012");
                            vulnerabilities.SetAsVulnerable("MS17-017");
                        }
                        if (version < 1198)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2017-0263");
                        }
                        if (version < 2248)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-8897");
                        }
                        if (version < 2430)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-0952");
                        }
                        if (version < 2485)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-8440");
                        }
                        break;

                    case "15063":
                        if (version < 296)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2017-0263");
                        }
                        if (version < 483)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-111");
                        }
                        if (version < 608)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-039");
                            vulnerabilities.SetAsVulnerable("MS16-123");
                        }
                        if (version < 1266)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-0952");
                        }
                        if (version < 1324)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-8440");
                        }
                        break;

                    case "16299":
                        if (version < 611)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-0952");
                        }
                        if (version < 665)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-8440");
                        }
                        break;

                    case "17134":
                        if (version < 48)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-8897");
                        }
                        if (version < 228)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-0952");
                        }
                        if (version < 285)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-8440");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                vulnerabilities.AddError(ex.Message);
            }

        }
    }
}
