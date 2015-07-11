@echo off
TItle Instalando Complementos
echo.
ver | findstr /i "5\.1\." > nul
IF %ERRORLEVEL% EQU 0 goto ver_XP

ver | findstr /i "6\.0\." > nul
IF %ERRORLEVEL% EQU 0 goto ver_Vista

ver | findstr /i "6\.1\." > nul
IF %ERRORLEVEL% EQU 0 goto ver_Win7

goto warn_and_exit

:ver_Win7
:Run Windows 7 specific commands here
echo --------INSTALANDO COMPLEMENTOS---------------
echo --------Por favor no cierre esta pantalla!!!!!!!!!!!!!!!!!!
c:\tercero.exe /passive /norestart
echo --- ----Finalinzando Instalacion FrameWorks
echo --------INSTALANDO Base de Datos
c:\SQlite.exe /silent /norestart
echo --- Finalizando Instalacion SQLite
@echo off 
echo --------Estamos finalizando la instalacion, clic en Next luego install
for /f "skip=1" %%x in ('wmic logicaldisk get caption') do ( 
for /f "tokens=1" %%c in ('fsutil fsinfo drivetype %%x') do ( 
	%%c\install\setup.exe
) 
) 


echo set WshShell = WScript.CreateObject("WScript.Shell") > %tmp%\tmp.vbs
echo WScript.Quit (WshShell.Popup( "La instalacion a Finaliazado exitosamente, Su computadora se reiniciara en 10 Segundos...." ,10 ,"Mensaje", 0)) >> %tmp%\tmp.vbs
cscript /nologo %tmp%\tmp.vbs
if %errorlevel%==1 (
  SHUTDOWN /R /T 10 
) else (
  echo The Message timed out.
)
del %tmp%\tmp.vbs

 SHUTDOWN /R /T 10 

goto end

:ver_Vista
:Run Windows Vista specific commands here
c:\firefox.exe /silent /admin /norestart
goto end

:ver_XP
:Run Windows XP specific commands here
echo --------INSTALANDO COMPLEMENTOS---------------
echo --------Por favor no cierre esta pantalla!!!!!!!!!!!!!!!!!!
echo --------INSTALANDO primer Complemento
c:\primero.exe /quiet /norestart
echo --------INSTALANDO Segundo Complemento
c:\segundo.exe /quiet /norestart
echo --------INSTALANDO Framework
c:\tercero.exe /passive /norestart
echo --------INSTALANDO Base de Datos
c:\SQlite.exe /silent /norestart
@echo off 
echo --------Estamos finalizando la instalacion, clic en Next luego install
for /f "skip=1" %%x in ('wmic logicaldisk get caption') do ( 
for /f "tokens=1" %%c in ('fsutil fsinfo drivetype %%x') do ( 
	%%c\install\setup.exe
) 
) 

echo set WshShell = WScript.CreateObject("WScript.Shell") > %tmp%\tmp.vbs
echo WScript.Quit (WshShell.Popup( "La instalacion a Finaliazado exitosamente, Su computadora se reiniciara en 10 Segundos...." ,10 ,"Mensaje", 0)) >> %tmp%\tmp.vbs
cscript /nologo %tmp%\tmp.vbs
if %errorlevel%==1 (
  SHUTDOWN /R /T 10 
) else (
  echo The Message timed out.
)
del %tmp%\tmp.vbs

 SHUTDOWN /R /T 10

goto end

:warn_and_exit
echo --------INSTALANDO Base de Datos
c:\SQlite.exe /silent /norestart
@echo off 
echo --------Estamos finalizando la instalacion, clic en Next luego install
for /f "skip=1" %%x in ('wmic logicaldisk get caption') do ( 
for /f "tokens=1" %%c in ('fsutil fsinfo drivetype %%x') do ( 
	%%c\install\setup.exe
) 
) 

echo set WshShell = WScript.CreateObject("WScript.Shell") > %tmp%\tmp.vbs
echo WScript.Quit (WshShell.Popup( "La instalacion a Finaliazado exitosamente, Su computadora se reiniciara en 10 Segundos...." ,10 ,"Mensaje", 0)) >> %tmp%\tmp.vbs
cscript /nologo %tmp%\tmp.vbs
if %errorlevel%==1 (
  SHUTDOWN /R /T 10 
) else (
  echo The Message timed out.
)
del %tmp%\tmp.vbs

 SHUTDOWN /R /T 10
goto end

:end  

pause
exit
  