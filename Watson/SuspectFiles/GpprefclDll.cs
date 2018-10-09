using System;

namespace Watson.SuspectFiles
{
    internal static class GpprefclDll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\gpprefcl.dll");

                switch (sysInfo.OsBuild)
                {
                    case "10240":
                        if (version < 16942)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-072");
                        }
                        break;

                    case "10586":
                        if (version < 420)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-072");
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
