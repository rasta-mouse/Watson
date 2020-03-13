using System;
using System.Collections.Generic;

using Watson.Msrc;

namespace Watson
{
    class Program
    {
        static void Main(string[] args)
        {
            Info.PrintLogo();

            // Supported versions
            List<string> supportedVersions = new List<string>()
            {
                "10240", //1507
                "10586", //1511
                "14393", //1607 & 2K16
                "15063", //1703
                "16299", //1709
                "17134", //1803
                "17763", //1809 & 2K19
                "18362", //1903
                "18363", //1909
            };

            // Get OS Build number
            string buildNumber = Wmi.GetBuildNumber();
            if (!string.IsNullOrEmpty(buildNumber))
                Console.WriteLine(" [*] OS Build Number: {0}", buildNumber);
            else
                return;

            if (!supportedVersions.Contains(buildNumber))
            {
                Console.WriteLine(" [!] Windows version not supported\r\n");
                return;
            }

            // List of KBs installed
            Console.WriteLine(" [*] Enumerating installed KBs...\r\n");
            List<string> installedKBs = Wmi.GetInstalledKBs();

#if DEBUG
            foreach (string kb in installedKBs)
                Console.WriteLine(" {0}", kb);
            Console.WriteLine();
#endif

            // List of Vulnerabilities
            VulnerabilityCollection vulnerabiltiies = new VulnerabilityCollection();

            // Check each one
            CVE_2019_0836.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_0841.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_1064.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_1130.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_1253.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_1315.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_1385.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_1388.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_1405.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2020_0796.Check(vulnerabiltiies, buildNumber, installedKBs);

            // Print the results
            vulnerabiltiies.ShowResults();
        }
    }
}