::
:: execute this file to build and test the FizzBuzz Kata
::
dotnet --version
if %ERRORLEVEL% GEQ 1 GOTO EnvironmentError

dotnet build 
if %ERRORLEVEL% GEQ 1 GOTO BuildError

dotnet test test/test.csproj
if %ERRORLEVEL% GEQ 1 GOTO TestError

echo ---SUCCESS---
::pause
EXIT /B

:: Error Handling

:EnvironmentError
echo ===Error Invoking dotnet Command===
echo Maybe you need to install .NET Core SDK?
::pause
EXIT /B 1

:BuildError
echo ===Error Building===
::pause
EXIT /B 1

:TestError
echo ===Error During Unit Tests===
::pause
EXIT /B 1
