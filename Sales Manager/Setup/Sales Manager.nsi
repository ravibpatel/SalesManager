﻿; Script generated by the HM NIS Edit Script Wizard.

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "Sales Manager"
!define PRODUCT_VERSION "1.0.8"
VIProductVersion 1.0.8.0
!define PRODUCT_PUBLISHER "RBSoft Inc."
!define PRODUCT_WEB_SITE "http://www.rbsoft.org"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\Sales Manager.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

VIAddVersionKey ProductName "${PRODUCT_NAME}"
VIAddVersionKey CompanyName "${PRODUCT_PUBLISHER}"
VIAddVersionKey LegalCopyright "Copyright © 2017-2019 RBSoft"
VIAddVersionKey FileVersion ${PRODUCT_VERSION}
VIAddVersionKey FileDescription "Sales Manager - Track your Envato market sales"
VIAddVersionKey ProductVersion ${PRODUCT_VERSION}
VIAddVersionKey InternalName "Sales Manager Setup"

SetCompressor lzma

; MUI 1.67 compatible ------
!include "MUI.nsh"
!include "DotNetChecker.nsh"

; MUI Settings
!define MUI_ABORTWARNING
!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\nsis3-install.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\nsis3-uninstall.ico"
!define MUI_HEADERIMAGE_BITMAP "nsis3-metro-right.bmp"

; Welcome page
!insertmacro MUI_PAGE_WELCOME
; License page
!insertmacro MUI_PAGE_LICENSE "..\bin\Release\License.txt"
; Directory page
!insertmacro MUI_PAGE_DIRECTORY
; Instfiles page
!insertmacro MUI_PAGE_INSTFILES
; Finish page
!define MUI_FINISHPAGE_RUN "$INSTDIR\Sales Manager.exe"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "English"

; Reserve files
!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS

; MUI end ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "..\..\Sales.Manager.Setup.exe"
InstallDir "$PROGRAMFILES\RBSoft\Sales Manager"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails show
ShowUnInstDetails show

Section "MainSection" SEC01
  !insertmacro CheckNetFramework 452
  
  SetOutPath "$INSTDIR"
  File "..\bin\Release\Sales Manager.exe"
  CreateDirectory "$SMPROGRAMS\Sales Manager"
  CreateShortCut "$SMPROGRAMS\Sales Manager\Sales Manager.lnk" "$INSTDIR\Sales Manager.exe"
  CreateShortCut "$DESKTOP\Sales Manager.lnk" "$INSTDIR\Sales Manager.exe"
  File "..\bin\Release\Sales Manager.exe.config"
  File "..\bin\Release\Sales Manager.pdb"
  File "..\bin\Release\License.txt"
  File "..\bin\Release\Help.chm"
  SetOutPath "$INSTDIR\x64"
  File "..\bin\Release\x64\sqlite3.dll"
  SetOutPath "$INSTDIR\x86"
  File "..\bin\Release\x86\sqlite3.dll"
SectionEnd

Section -AdditionalIcons
  SetOutPath $INSTDIR
  WriteIniStr "$INSTDIR\${PRODUCT_NAME}.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
  CreateShortCut "$SMPROGRAMS\Sales Manager\Website.lnk" "$INSTDIR\${PRODUCT_NAME}.url"
  CreateShortCut "$SMPROGRAMS\Sales Manager\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\Sales Manager.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\Sales Manager.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd


Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer."
FunctionEnd

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Are you sure you want to completely remove $(^Name) and all of its components?" IDYES +2
  Abort
FunctionEnd

Section Uninstall
  Delete "$INSTDIR\${PRODUCT_NAME}.url"
  Delete "$INSTDIR\uninst.exe"
  Delete "$INSTDIR\x86\sqlite3.dll"
  Delete "$INSTDIR\x64\sqlite3.dll"
  Delete "$INSTDIR\License.txt"
  Delete "$INSTDIR\Help.chm"
  Delete "$INSTDIR\Sales Manager.pdb"
  Delete "$INSTDIR\Sales Manager.exe.config"
  Delete "$INSTDIR\Sales Manager.exe"

  Delete "$SMPROGRAMS\Sales Manager\Uninstall.lnk"
  Delete "$SMPROGRAMS\Sales Manager\Website.lnk"
  Delete "$DESKTOP\Sales Manager.lnk"
  Delete "$SMPROGRAMS\Sales Manager\Sales Manager.lnk"

  RMDir "$SMPROGRAMS\Sales Manager"
  RMDir "$INSTDIR\x86"
  RMDir "$INSTDIR\x64"
  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd