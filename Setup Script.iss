#include "Inno Plugins\idp.iss"

#define MyAppName "Outlook on the Desktop"
#define MyAppVersion GetFileVersion('OotD.Launcher\bin\Release\netcoreapp3.0\OotD.Launcher.exe')
#define MyAppVerName "Outlook on the Desktop {#MyAppVersion}"
#define MyAppPublisher "Michael Scrivo"
#define MyAppURL "https://outlookonthedesktop.com"
#define MyAppExeName "OotD.Launcher.exe"
#define MyAppCopyright "�2006-2019 Michael Scrivo"

[Setup]
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultGroupName={#MyAppName}
DefaultDirName={pf}\{#MyAppName}
VersionInfoCompany={#MyAppPublisher}
VersionInfoCopyright={#MyAppCopyright}
AppCopyright={#MyAppCopyright}
OutputBaseFilename=ootd-{#MyAppVersion}
Compression=lzma
SolidCompression=true
VersionInfoVersion={#MyAppVersion}
VersionInfoDescription={#MyAppName}
WizardImageFile=Inno Plugins\WizModernImage-IS.bmp
WizardSmallImageFile=Inno Plugins\WizModernSmallImage-IS.bmp
AppID={{6D9785D9-FF53-4C06-9C2A-E4173D41A2FD}
ShowLanguageDialog=yes
OutputDir=ServerStaging
MinVersion=0,6.0.6001sp2
AllowUNCPath=false
UninstallLogMode=append
UninstallDisplayIcon={app}\OotD.Launcher.exe
PrivilegesRequired=none
DisableDirPage=auto
DisableReadyMemo=True
DisableProgramGroupPage=yes
UsePreviousGroup=False

[Languages]
Name: eng; MessagesFile: compiler:Default.isl

[Run]
Filename: "{app}\{#MyAppExeName}"; Parameters: "-s"; WorkingDir: "{app}"; Flags: postinstall waituntilterminated runasoriginaluser runhidden; Description: "Run on Startup"
Filename: "{app}\{#MyAppExeName}"; WorkingDir: "{app}"; Flags: postinstall skipifsilent nowait runasoriginaluser; Description: "{cm:LaunchProgram,{#MyAppName}}"

[Files]
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\AxInterop.Microsoft.Office.Interop.OutlookViewCtl.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\Microsoft.Office.Interop.Outlook.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\CommandLine.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\MACTrackBarLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\MarkdownSharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\Microsoft.Win32.TaskScheduler.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\NetSparkle.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\NLog.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\NLog.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OLXLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.Launcher.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.Launcher.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.Launcher.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.Launcher.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.x64.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.x64.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.x64.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.x64.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.x86.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.x86.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.x86.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotD.x86.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "OotD.Launcher\bin\Release\netcoreapp3.0\OotDScheduledTaskDefinition.xml"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: {group}\{#MyAppName}; Filename: {app}\{#MyAppExeName}; WorkingDir: {app}
Name: {group}\{cm:ProgramOnTheWeb,{#MyAppName}}; Filename: {#MyAppURL}
Name: {group}\{cm:UninstallProgram,{#MyAppName}}; Filename: {uninstallexe}

[Registry]
Root: "HKCU"; Subkey: "Software\Microsoft\Windows\CurrentVersion\Run"; ValueName: "OutlookOnDesktop"; ValueType: string; Flags: deletevalue;
Root: "HKCU"; Subkey: "Software\SMR Computer Services\Outlook On The Desktop"; Flags: createvalueifdoesntexist uninsdeletekey
Root: "HKCU"; Subkey: "Software\SMR Computer Services\Outlook On The Desktop\"; ValueType: string; ValueName: "First Run"; ValueData: "True"
Root: "HKCU"; Subkey: "Software\SMR Computer Services\Outlook On The Desktop\AutoUpdate"; Flags: createvalueifdoesntexist uninsdeletekey

[Dirs]
Name: "{app}\logs"; Permissions: everyone-modify

[UninstallRun]
Filename: "taskkill"; Parameters: "/f /im OotD.x86.exe"; Flags: runhidden
Filename: "taskkill"; Parameters: "/f /im OotD.x64.exe"; Flags: runhidden
Filename: "schtasks"; Parameters: "/DELETE /F /TN ""Outlook on the Desktop"""; Flags: runhidden

[Code]
const
	dotnetCore3HostingBundleUrl = 'https://download.visualstudio.microsoft.com/download/pr/bf79e503-defd-4034-a5d4-a5c055f5d589/7383e4dac92dc0cc7f1075321d6394c6/dotnet-hosting-3.0.0-preview7.19365.7-win.exe';
const
  dotnetCore3HostingBundleFilename = 'dotnet-hosting-3.0.0-preview7.19365.7-win.exe';

procedure InitializeWizard;
begin
  idpAddFile(dotnetCore3HostingBundleUrl, ExpandConstant('{tmp}\$dotnetCore3HostingBundleFilename'));

  idpDownloadAfter(wpReady);
end;

function PrepareToInstall(var NeedsRestart: Boolean): String;
var
  nCode: Integer;
begin
    if FileExists(ExpandConstant('{tmp}\$dotnetCore3HostingBundleFilename')) then 
    begin 
      Exec(ExpandConstant('{tmp}\$dotnetCore3HostingBundleFilename'),'/install /passive /quiet /norestart','',SW_SHOW,ewWaitUntilTerminated,nCode)
    end  
end;

procedure TaskKill(FileName: String);
var
  ResultCode: Integer;
begin
  Exec(ExpandConstant('taskkill.exe'), '/f /im ' + '"' + FileName + '"', '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
end;

function HasOldx64Version(): Boolean;
begin
  Result := FileExists('C:\Program Files\Outlook on the Desktop\unins000.exe');
end;

function UnInstallOldVersion(): Integer;
var
  sUnInstallString: String;
  iResultCode: Integer;
begin
  // Return Values:
  // 2 - error executing the UnInstallString
  // 3 - successfully executed the UnInstallString

  // default return value
  Result := 0;

  Exec('taskkill', '/f /im OutlookDesktop.exe', '', SW_HIDE,  ewWaitUntilTerminated, iResultCode);

  if Exec('C:\Program Files\Outlook on the Desktop\unins000.exe', '/SILENT /NORESTART /SUPPRESSMSGBOXES','', SW_HIDE, ewWaitUntilTerminated, iResultCode) then
    Result := 3
  else
    Result := 2;
end;

procedure CurStepChanged(CurStep: TSetupStep);
begin
  if (CurStep=ssInstall) then
  begin
    if (HasOldx64Version()) then
    begin
      UnInstallOldVersion();
    end;
  end;
end;

[UninstallDelete]
Name: {app}\*; Type: filesandordirs
Name: {app}; Type: dirifempty

[InstallDelete]
Name: C:\{app}\*; Type: filesandordirs
Name: C:\{app}; Type: dirifempty