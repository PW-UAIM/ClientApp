docker login -u majumi -p uaimrzadzi

docker rmi majumi/application:zsutpwpatterns-webapplication

docker build -f ../majumi.ClientApp.BlazorServer/Dockerfile.prod -t majumi/application:zsutpwpatterns-webapplication ..

docker images

docker image ls --filter label=stage=zsutpwpatterns-webapplication_build

docker image prune --filter label=stage=zsutpwpatterns-webapplication_build --force

docker push majumi/application:zsutpwpatterns-webapplication

docker images

docker logout

pause
