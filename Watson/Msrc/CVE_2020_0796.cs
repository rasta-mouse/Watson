using System.Linq;
using System.Collections.Generic;

namespace Watson.Msrc
{
    internal static class CVE_2020_0796
    {
        private const string name = "CVE-2020-0796";

        public static void Check(VulnerabilityCollection vulnerabilities, string BuildNumber, List<string> installedKBs)
        {
            List<string> Supersedence = new List<string>();

            switch (BuildNumber)
            {
                case "18362":
                case "18363":

                    Supersedence.AddRange(new string[] {
                        "4551762"
                    });

                    break;

                default:
                    return;
            }

            IEnumerable<string> x = Supersedence.Intersect(installedKBs);

            if (!x.Any())
                vulnerabilities.SetAsVulnerable(name);
        }
    }
}
