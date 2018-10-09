using System;

namespace Watson.SuspectFiles
{
    internal static class Rpcrt4Dll
    {
        public static void Check(VulnerabilityCollection vulnerabilities, SystemInfo sysInfo)
        {
            try
            {
                int version = SystemInfoHelpers.GetFileVersionInfoProductPrivatePart(sysInfo.WinPath + "\\rpcrt4.dll");

                switch (sysInfo.OsBuild)
                {
                    case "6002":
                        if (version < 19431)
                        {
                            vulnerabilities.SetAsVulnerable("MS15-076");
                        }
                        break;

                    case "9200":
                        if (version < 17422)
                        {
                            vulnerabilities.SetAsVulnerable("MS15-076");
                        }
                        break;

                    case "9600":
                        if (version < 17919)
                        {
                            vulnerabilities.SetAsVulnerable("MS15-076");
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
