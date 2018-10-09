using System;

namespace Watson.SuspectFiles
{
    internal static class GdiplusDll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\gdiplus.dll");

                switch (sysInfo.OsBuild)
                {
                    case "10240":
                        if (version < 17146)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-101");
                            vulnerabilities.SetAsVulnerable("MS16-123");
                            vulnerabilities.SetAsVulnerable("MS16-125");
                        }
                        break;

                    case "10586":
                        if (version < 633)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-101");
                            vulnerabilities.SetAsVulnerable("MS16-123");
                            vulnerabilities.SetAsVulnerable("MS16-125");
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
