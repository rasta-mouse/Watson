# Watson

Watson is a .NET tool designed to enumerate missing KBs and suggest exploits for Privilege Escalation vulnerabilities.

## Supported Versions

- Windows 10 1507, 1511, 1607, 1703, 1709, 1803, 1809, 1903, 1909, 2004
- Server 2016 & 2019

## Usage

```
C:\> Watson.exe
  __    __      _
 / / /\ \ \__ _| |_ ___  ___  _ __
 \ \/  \/ / _` | __/ __|/ _ \| '_ \
  \  /\  / (_| | |_\__ \ (_) | | | |
   \/  \/ \__,_|\__|___/\___/|_| |_|

                           v2.0

                   @_RastaMouse

 [*] OS Build Number: 14393
 [*] Enumerating installed KBs...

 [!] CVE-2019-0836 : VULNERABLE
  [>] https://exploit-db.com/exploits/46718
  [>] https://decoder.cloud/2019/04/29/combinig-luafv-postluafvpostreadwrite-race-condition-pe-with-diaghub-collector-exploit-from-standard-user-to-system/

 [!] CVE-2019-0841 : VULNERABLE
  [>] https://github.com/rogue-kdc/CVE-2019-0841
  [>] https://rastamouse.me/tags/cve-2019-0841/

 [!] CVE-2019-1064 : VULNERABLE
  [>] https://www.rythmstick.net/posts/cve-2019-1064/

 [!] CVE-2019-1130 : VULNERABLE
  [>] https://github.com/S3cur3Th1sSh1t/SharpByeBear

 [!] CVE-2019-1253 : VULNERABLE
  [>] https://github.com/padovah4ck/CVE-2019-1253

 [!] CVE-2019-1315 : VULNERABLE
  [>] https://offsec.almond.consulting/windows-error-reporting-arbitrary-file-move-eop.html

 [*] Finished. Found 6 potential vulnerabilities.
```

## Issues

- I try to update Watson after every Patch Tuesday, but for potential false positives check the latest supersedence information in the [Windows Update Catalog](https://www.catalog.update.microsoft.com/Home.aspx).  If you still think there's an error, raise an Issue with the `Bug` label.

- If there's a particular vulnerability that you want to see in Watson that's not already included, raise an Issue with the `Vulnerability Request` label and include the CVE number.

- If you know of a good exploit for any of the vulnerabilities in Watson, raise an Issue with the `Exploit Suggestion` label and provide a URL to the exploit.