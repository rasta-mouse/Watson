using System;
using System.Collections.Generic;
using Watson2.Msrc;

namespace Watson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Info.PrintLogo();

            // OS Build number
            string buildNumber = Wmi.GetBuildNumber();
            Console.WriteLine(" [*] OS Build Number: {0}", buildNumber);

            // Supported version?
            List<string> supportedVersions = new List<string>()
            {
                // 1703   1709     1803     1809
                "15063", "16299", "17134", "17763"
            };

            if (!supportedVersions.Contains(buildNumber))
            {
                Console.WriteLine(" [!] Windows version not supported\r\n");
                Environment.Exit(1);
            }

            // List of KBs installed
            Console.WriteLine(" [*] Enumerating installed KBs...\r\n");
            List<string> installedKBs = Wmi.GetInstalledKBs();

#if DEBUG
            foreach (string kb in installedKBs)
                Console.WriteLine(kb);
            Console.WriteLine();
#endif

            // List of Vulnerabilities
            VulnerabilityCollection vulnerabiltiies = new VulnerabilityCollection();

            // Check each one
            CVE_2018_8440.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2018_8897.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_0841.Check(vulnerabiltiies, buildNumber, installedKBs);
            CVE_2019_0863.Check(vulnerabiltiies, buildNumber, installedKBs);

            // Print the results
            vulnerabiltiies.ShowResults();
        }
    }
}