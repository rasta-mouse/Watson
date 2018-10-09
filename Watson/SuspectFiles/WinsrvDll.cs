using System;

namespace Watson.SuspectFiles
{
    internal static class WinsrvDll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\winsrv.dll");
                switch (sysInfo.OsBuild)
                {
                    case "6001":
                        if (version < 18638)
                        {
                            vulnerabilities.SetAsVulnerable("MS11-056");
                        }

                        break;

                    case "6002":
                        if (version < 18456)
                        {
                            vulnerabilities.SetAsVulnerable("MS11-056");
                        }

                        break;

                    case "7600":
                        if (version < 16816)
                        {
                            vulnerabilities.SetAsVulnerable("MS11-056");
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
