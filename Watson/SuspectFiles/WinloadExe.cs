using System;

namespace Watson.SuspectFiles
{
    internal static class WinloadExe
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\winload.exe");

                switch (sysInfo.OsBuild)
                {
                    case "16299":
                        if (version < 431)
                        {
                            vulnerabilities.SetAsVulnerable("CVE-2018-8897");
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
