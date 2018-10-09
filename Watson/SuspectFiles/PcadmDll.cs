using System;

namespace Watson.SuspectFiles
{
    internal static class PcadmDll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\pcadm.dll");

                switch (sysInfo.OsBuild)
                {
                    case "10240":
                        if (version < 17861)
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
