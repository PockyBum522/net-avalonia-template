REM -------========== Unique.Id.To.Be.Replaced.Core ==========-------

set folder=".\Unique.Id.To.Be.Replaced.Core\bin"

cd /d %folder%

for /F "delims=" %%i in ('dir /b') do (rmdir "%%i" /s/q 2>NUL || del "%%i" /s/q >NUL )

set folder="..\obj"

cd /d %folder%

for /F "delims=" %%i in ('dir /b') do (rmdir "%%i" /s/q 2>NUL || del "%%i" /s/q >NUL )

REM  -------========== Unique.Id.To.Be.Replaced.Main ==========-------

set folder="..\..\Unique.Id.To.Be.Replaced.Main\bin"

cd /d %folder%

for /F "delims=" %%i in ('dir /b') do (rmdir "%%i" /s/q 2>NUL || del "%%i" /s/q >NUL )

set folder="..\obj"

cd /d %folder%

for /F "delims=" %%i in ('dir /b') do (rmdir "%%i" /s/q 2>NUL || del "%%i" /s/q >NUL )

REM  -------========== Unique.Id.To.Be.Replaced.UI ==========-------

set folder="..\..\Unique.Id.To.Be.Replaced.UI\bin"

cd /d %folder%

for /F "delims=" %%i in ('dir /b') do (rmdir "%%i" /s/q 2>NUL || del "%%i" /s/q >NUL )

set folder="..\obj"

cd /d %folder%

for /F "delims=" %%i in ('dir /b') do (rmdir "%%i" /s/q 2>NUL || del "%%i" /s/q >NUL )

pause
