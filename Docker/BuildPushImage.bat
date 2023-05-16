::docker login -u atomaszewski
:: -p <password>

docker rmi atomaszewski/application:zsutpwpatterns-webapplication

docker build -f ../ZsutPwPatterns.WebApplication.BlazorServer/Dockerfile.prod -t atomaszewski/application:zsutpwpatterns-webapplication ..

docker images

docker image ls --filter label=stage=zsutpwpatterns-webapplication_build

docker image prune --filter label=stage=zsutpwpatterns-webapplication_build --force

docker push atomaszewski/application:zsutpwpatterns-webapplication

docker images

::docker logout

pause
