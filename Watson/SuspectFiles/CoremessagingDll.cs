using System;

namespace Watson.SuspectFiles
{
    internal static class CoremessagingDll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\coremessaging.dll");

                switch (sysInfo.OsBuild)
                {
                    case "15063":
                        if (version < 1088)
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
