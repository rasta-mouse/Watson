using System;

namespace Watson.SuspectFiles
{
    internal static class Win32kfullSys
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\win32kfull.sys");

                switch (sysInfo.OsBuild)
                {
                    case "10240":
                        if (version < 16683)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-014");
                        }
                        if (version < 16724)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-034");
                        }
                        if (version < 16771)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-039");
                        }
                        break;

                    case "10586":
                        if (version < 103)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-014");
                        }
                        if (version < 162)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-034");
                        }
                        if (version < 212)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-039");
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
