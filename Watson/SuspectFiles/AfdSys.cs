using System;

namespace Watson.SuspectFiles
{
    internal static class AfdSys
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\drivers\\afd.sys");

                switch (sysInfo.OsBuild)
                {
                    case "6001":
                        if (version < 18639)
                        {
                            vulnerabilities.SetAsVulnerable("MS11-046");
                        }

                        break;

                    case "6002":
                        if (version < 18457)
                        {
                            vulnerabilities.SetAsVulnerable("MS11-046");
                        }

                        break;

                    case "7600":
                        if (version < 16802)
                        {
                            vulnerabilities.SetAsVulnerable("MS11-046");
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
