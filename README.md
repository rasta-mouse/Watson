# Watson

Watson is a .NET tool designed to enumerate missing KBs and suggest exploits for useful Privilege Escalation vulnerabilities.

My focus is on the latest priv esc's for the mainstream Operating Systems, to help pentesters leverage that timeframe between Patch Tuesday and patch deployment.

## Supported Versions

- Windows 10 1703, 1709, 1803 & 1809
- Server 2016

## Basic Usage

```
C:\> Watson-2.0.exe
  __    __      _
 / / /\ \ \__ _| |_ ___  ___  _ __
 \ \/  \/ / _` | __/ __|/ _ \| '_ \
  \  /\  / (_| | |_\__ \ (_) | | | |
   \/  \/ \__,_|\__|___/\___/|_| |_|

                           v2.0

                   @_RastaMouse

 [*] OS Build Number: 17763
 [*] Enumerating installed KBs...

 [!] CVE-2018-8440 : VULNERABLE
  [>] https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/alpc_taskscheduler.rb

 [!] CVE-2018-8897 : VULNERABLE
  [>] https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/mov_ss.rb

 [!] CVE-2019-0841 : VULNERABLE
  [>] https://github.com/rogue-kdc/CVE-2019-0841
  [>] https://rastamouse.me/tags/cve-2019-0841/

 [!] CVE-2019-0863 : VULNERABLE
  [>] Exploits Unknown

 [*] Finished. Found 4 potential vulnerabilities.
```