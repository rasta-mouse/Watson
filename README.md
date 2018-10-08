# Watson

Watson is a (.NET 2.0 compliant) C# implementation of [Sherlock](https://github.com/rasta-mouse/Sherlock).

## Basic Usage

Ensure you use the correct .NET Framework version for your target system, as described [here](https://rastamouse.me/2018/09/a-lesson-in-.net-framework-versions/).

Run the exe from disk or via the `execute-assembly` functionality within [Cobalt Strike](https://cobaltstrike.com/), [SILENTTRINITY](https://github.com/byt3bl33d3r/SILENTTRINITY) etc.

```
beacon> execute-assembly C:\Users\Rasta\source\repos\Watson\Watson\bin\Debug\Watson.exe
[*] Tasked beacon to run .NET program: Watson.exe
[+] host called home, sent: 135211 bytes
[+] received output:
  __    __      _                   
 / / /\ \ \__ _| |_ ___  ___  _ __  
 \ \/  \/ / _` | __/ __|/ _ \| '_ \ 
  \  /\  / (_| | |_\__ \ (_) | | | |
   \/  \/ \__,_|\__|___/\___/|_| |_|
                                   
                           v0.1    
                                   
                  Sherlock sucks...
                   @_RastaMouse

 [*] OS Build number: 14393
 [*] CPU Address Width: 64
 [*] Processs IntPtr Size: 8
 [*] Using Windows path: C:\WINDOWS\System32

  [*] Appears vulnerable to CVE-2018-8897
   [>] Description: An EoP exists when the Windows kernel fails to properly handle objects in memory.
   [>] Exploit: https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/mov_ss.rb
   [>] Notes: May not work on all hypervisors.

  [*] Appears vulnerable to CVE-2018-0952
   [>] Description: An EoP exists when Diagnostics Hub Standard Collector allows file creation in arbitrary locations. 
   [>] Exploit: https://www.exploit-db.com/exploits/45244/
   [>] Notes: None

  [*] Appears vulnerable to CVE-2018-8440
   [>] Description: An EoP exists when Windows improperly handles calls to Advanced Local Procedure Call (ALPC).
   [>] Exploit: https://github.com/rapid7/metasploit-framework/blob/master/modules/exploits/windows/local/alpc_taskscheduler.rb
   [>] Notes: None.

 [*] Finished. Found 3 vulns :)
```

## Contributions

I'm always on the look-out for new priv esc vulnerabilities to include.

If you don't feel comfortable or confident submitting a PR yourself, feel free to drop a GitHub issue and tag it as a vulnerability request.