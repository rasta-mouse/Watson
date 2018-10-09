using System;

namespace Watson.SuspectFiles
{
    internal static class  Gdi32Dll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\gdi32.dll");

                switch (sysInfo.OsBuild)
                {
                    case "10240":
                        if (version < 17319)
                        {
                            vulnerabilities.SetAsVulnerable("MS17-012");
                            vulnerabilities.SetAsVulnerable("MS17-017");
                        }
                        if (version < 17394)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2017-0263");
                        }
                        break;

                    case "10586":
                        if (version < 839)
                        {
                            vulnerabilities.SetAsVulnerable("MS17-012");
                            vulnerabilities.SetAsVulnerable("MS17-017");
                        }
                        if (version < 916)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2017-0263");
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
