using System;

namespace Watson.SuspectFiles
{
    internal static class AtmfdDll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\atmfd.dll");

                switch (sysInfo.OsBuild)
                {
                    case "9200":
                        if (version < 243)
                        {
                            vulnerabilities.SetAsVulnerable("MS15-078");
                        }
                        break;

                    case "9600":
                        if (version < 243)
                        {
                            vulnerabilities.SetAsVulnerable("MS15-078");
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
