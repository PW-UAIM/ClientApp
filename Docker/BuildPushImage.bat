docker login -u majumi -p uaimrzadzi

docker rmi majumi/clientapp:application

docker build -f ../majumi.ClientApp.BlazorServer/Dockerfile.prod -t majumi/clientapp:application ..

docker images

docker image ls --filter label=stage=zsutpwpatterns-webapplication_build

docker image prune --filter label=stage=zsutpwpatterns-webapplication_build --force

docker push majumi/clientapp:application

docker images

docker logout

pause
