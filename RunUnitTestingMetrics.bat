@ECHO ON

REM OpenCover-VSTest.bat

REM Run opencover against MSTest tests in your test project and show report of code coverage


SET DllContainingTests=%~dp0DakarRally.NetDusanj.Test\bin\Debug\net5.0\DakarRally.NetDusanj.Test.dll


REM *** IMPORTANT - Change DllContainingTests variable (above) to point to the DLL 
REM ***             in your solution containing your NUnit tests
REM ***
REM ***             You may also want to change the include/exclude filters 
REM ***             (below) for OpenCover
REM ***
REM ***             This batch file should dbe placed in the root folder of your solution

REM *** Before being able to use this to generate coverage reports you will 
REM *** need the following NuGet packages
REM PM> Install-Package OpenCover
REM PM> Install-Package ReportGenerator
REM

REM *** MSTest Test Runner (VS2013, will need to change 12.0 to 14.0 for VS2015)
SET TestRunnerExe=%PROGRAMFILES(X86)%\Microsoft Visual Studio\2019\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe

REM Get OpenCover Executable (done this way so we dont have to change 
REM the code when the version number changes)
SET OpenCoverExe=C:\Users\dusan\.nuget\packages\opencover\4.7.922\tools\OpenCover.Console.exe

REM Get Report Generator (done this way so we dont have to change the code 
REM when the version number changes)
SET ReportGeneratorExe=C:\Users\dusan\.nuget\packages\reportgenerator\4.8.8\tools\netcoreapp3.0\ReportGenerator.exe

REM Create a 'GeneratedReports' folder if it does not exist
if not exist "%~dp0GeneratedReports" mkdir "%~dp0GeneratedReports"

REM Run the tests against the targeted output
call :RunOpenCoverUnitTestMetrics

REM Generate the report output based on the test results
if %errorlevel% equ 0 ( 
 call :RunReportGeneratorOutput 
)

REM Launch the report
if %errorlevel% equ 0 ( 
 call :RunLaunchReport 
)
exit /b %errorlevel%

:RunOpenCoverUnitTestMetrics 
REM *** Change the filter to include/exclude parts of the solution you want to 
REM *** check for test coverage
"%OpenCoverExe%" ^
 -target:"%TestRunnerExe%" ^
 -targetargs:"\"%DllContainingTests%\"" ^
 -filter:"+[*]* -[*.Tests*]* -[*]*.Global -[*]*.RouteConfig -[*]*.WebApiConfig" ^
 -mergebyhash ^
 -skipautoprops ^
 -register:user ^
 -output:"%~dp0GeneratedReports\CoverageReport.xml"
exit /b %errorlevel%

:RunReportGeneratorOutput
"%ReportGeneratorExe%" ^
 -reports:"%~dp0\GeneratedReports\CoverageReport.xml" ^
 -targetdir:"%~dp0\GeneratedReports\ReportGenerator Output"
exit /b %errorlevel%

:RunLaunchReport
start "report" "%~dp0\GeneratedReports\ReportGenerator Output\index.htm"
exit /b %errorlevel%