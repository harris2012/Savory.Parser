msbuild Savory.Parser.Net40\Savory.Parser.Net40.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Savory.Parser.xml;DebugType=none

nuget pack Savory.Parser.nuspec

rem move /y Savory.Parser.*.nupkg D:\GitlabWorkspace\ranta-app\RantaNuget\Packages

pause