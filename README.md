# New Era for developing Windows Service - .NET Core 3.1

As we know Windows services are ideal for long-term applications running in their own Windows sessions.

-------- **Features** --------
- Have no user interface
- Can be automatically started when the computer reboots
- Can also be stopped and restarted

## Do we benefit from .NET Core 3.1?

Yes. Old times in .NET framework, it's really painful of debugging the Windows Service application. Well, the tool TopShelf helped us a little bit, but not much. With the help of .NET Core 3.1 introducing the new features such as generic host, worker service and background service, the experience of writing a Windows Service application becomes more pleasant and efficient. Dive into the source codes in the projects, you'll find I don't lie.

## Deploy it using Cmd
	* Create a Windows Service
  
sc create WinWorkerService DisplayName="Windows Worker Service Demo" binPath="C:\fullPath\to\WinWorkerService.exe"
 
	* Start a Windows Service
  
sc start WinWorkerService
 
	* Stop a Windows Service
  
sc stop WinWorkerService
 
	* Delete a Windows Service
  
sc delete WinWorkerService

## Deploy it using PowerShell
Use the following Cmdlets: New-Service, Start-Service, Get-Service, Stop-Service, and Remove-Service.


## Note:
- binPath must be a FULL path
- Build it in Release mode
- Deploy it with the Administrator privilege

Have fun!

Jerry Sun
* Linkedin: http://nl.linkedin.com/in/jerysun
* Github:   https://github.com/jerysun/