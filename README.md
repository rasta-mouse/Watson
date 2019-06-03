# Watson

Watson is a .NET tool designed to enumerate missing KBs and suggest exploits for useful Privilege Escalation vulnerabilities.

My focus is on the latest priv esc's for the mainstream Operating Systems, to help pentesters leverage that timeframe between Patch Tuesday and patch deployment.

## Supported Versions

- Windows 10 1703, 1709, 1803 & 1809
- Server 2016 & 2019

## Basic Usage

```
C:\> Watson.exe
  __    __      _
 / / /\ \ \__ _| |_ ___  ___  _ __
 \ \/  \/ / _` | __/ __|/ _ \| '_ \
  \  /\  / (_| | |_\__ \ (_) | | | |
   \/  \/ \__,_|\__|___/\___/|_| |_|

                           v2.0

                   @_RastaMouse

 [*] OS Build Number: 17763
 [*] Enumerating installed KBs...

 [!] CVE-2019-0836 : VULNERABLE
  [>] https://exploit-db.com/exploits/46718
  [>] https://decoder.cloud/2019/04/29/combinig-luafv-postluafvpostreadwrite-race-condition-pe-with-diaghub-collector-exploit-from-standard-user-to-system/

 [!] CVE-2019-0841 : VULNERABLE
  [>] https://github.com/rogue-kdc/CVE-2019-0841
  [>] https://rastamouse.me/tags/cve-2019-0841/

 [!] CVE-2019-0863 : VULNERABLE
  [>] Exploits Unknown

 [*] Finished. Found 3 potential vulnerabilities.
```

## Issues

- I try to update Watson after every Patch Tuesday, but MS do sneak extra patches in for $reasons. For potential false positives, check the latest supersedence information in the Windows Update Catalog.  If you still think there's an error, raise an Issue with the "Bug" label.

- If there's a particular vulnerability that you want to see in Watson that's not already included, raise an Issue with the "Vulnerability Request" label and include the CVE number.

- If you know of a good exploit for any of the vulnerbilities in Watson, raise an Issue with the "Exploit Suggestion" label.