docker login -u majumi -p uaimrzadzi

docker rmi majumi/clientapp:application

docker build -f ../majumi.ClientApp.BlazorServer/Dockerfile.prod -t majumi/clientapp:application ..

docker logout

pause
