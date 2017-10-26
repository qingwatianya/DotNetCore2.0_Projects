%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe D:\VS2017_Projects\DotNetCore2.0_Projects\DotNetFrameWork_WindowsService_HangFire\bin\Release\DotNetFrameWork_WindowsService_HangFire.exe
Net Start TestService
sc config TestService start= auto
pause