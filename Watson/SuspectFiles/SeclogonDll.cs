using System;

namespace Watson.SuspectFiles
{
    internal static class SeclogonDll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\seclogon.dll");

                switch (sysInfo.OsBuild)
                {
                    case "6002":
                        if (version < 19598 && sysInfo.CpuCount > 1)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-032");
                        }
                        break;

                    case "9600":
                        if (version < 18230 && sysInfo.CpuCount > 1)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-032");
                        }
                        break;

                    case "10240":
                        if (version < 16724 && sysInfo.CpuCount > 1)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-032");
                        }
                        break;

                    case "10586":
                        if (version < 162 && sysInfo.CpuCount > 1)
                        {
                            vulnerabilities.SetAsVulnerable("MS16-032");
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
