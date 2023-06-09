docker login -u majumi -p uaimrzadzi
docker rmi majumi/clientapp:application

docker build -f ../majumi.ClientApp.BlazorServer/Dockerfile.prod -t majumi/clientapp:application .. || goto :error
docker logout

pause

:error
echo Failed with error #%errorlevel%.
pause
exit /b %errorlevel%
