using System;

namespace Watson.SuspectFiles
{
    internal static class SchedsvcDll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\schedsvc.dll");

                switch (sysInfo.OsBuild)
                {
                    case "6001":
                        if (version < 18551)
                        {
                            vulnerabilities.SetAsVulnerable("MS10-092");
                        }
                        break;

                    case "6002":
                        if (version < 18342)
                        {
                            vulnerabilities.SetAsVulnerable("MS10-092");
                        }
                        break;

                    case "7600":
                        if (version < 16699)
                        {
                            vulnerabilities.SetAsVulnerable("MS10-092");
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
