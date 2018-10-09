using System;

namespace Watson.SuspectFiles
{
    internal static class MrxdavSys
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\drivers\\mrxdav.sys");

                switch (sysInfo.OsBuild)
                {
                    case "6002":
                        if (version < 19576)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-016");
                        }
                        break;

                    case "9600":
                        if (version < 18189)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-016");
                        }
                        break;

                    case "10240":
                        if (version < 16683)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-016");
                        }
                        break;

                    case "10586":
                        if (version < 103)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-016");
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
