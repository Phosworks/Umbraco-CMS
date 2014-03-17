@ECHO OFF
echo Copying WebApp to Local IIS at %UMBRACO_HOME% 
xcopy %CD%\_BuildOutput\WebApp %UMBRACO_HOME% /E /I