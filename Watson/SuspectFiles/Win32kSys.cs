using System;

namespace Watson.SuspectFiles
{
    internal static class Win32kSys
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\win32k.sys");
                switch (sysInfo.OsBuild)
                {
                    case "6001":
                        if (version < 18523)
                        {
                            vulnerabilities.SetAsVulnerable("MS10-073");
                        }
                        break;

                    case "6002":
                        if (version < 18305)
                        {
                            vulnerabilities.SetAsVulnerable("MS10-073");
                        }
                        if (version < 18739)
                        {
                            vulnerabilities.SetAsVulnerable("MS13-005");
                        }
                        if (version < 18974)
                        {
                            vulnerabilities.SetAsVulnerable("MS13-101");
                        }
                        if (version < 19372)
                        {
                            vulnerabilities.SetAsVulnerable("MS15-051");
                        }
                        if (version < 19597)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-034");
                        }
                        break;

                    case "7600":
                        if (version < 16667)
                        {
                            vulnerabilities.SetAsVulnerable("MS10-073");
                        }
                        if (version < 17017)
                        {
                            vulnerabilities.SetAsVulnerable("MS12-042");
                        }
                        if (version < 17175)
                        {
                            vulnerabilities.SetAsVulnerable("MS13-005");
                        }
                        break;

                    case "9200":
                        if (version < 16468)
                        {
                            vulnerabilities.SetAsVulnerable("MS13-005");
                        }
                        if (version < 16758)
                        {
                            vulnerabilities.SetAsVulnerable("MS13-101");
                        }
                        if (version < 17130)
                        {
                            vulnerabilities.SetAsVulnerable("MS14-058");
                        }
                        if (version < 17343)
                        {
                            vulnerabilities.SetAsVulnerable("MS15-051");
                        }
                        break;

                    case "9600":
                        if (version < 16457)
                        {
                            vulnerabilities.SetAsVulnerable("MS13-101");
                        }
                        if (version < 17796)
                        {
                            vulnerabilities.SetAsVulnerable("MS15-051");
                        }
                        if (version < 17353)
                        {
                            vulnerabilities.SetAsVulnerable("MS14-058");
                        }
                        if (version < 18228)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-034");
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
