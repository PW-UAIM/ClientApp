::docker login -u atomaszewski
:: -p <password>

docker rmi atomaszewski/application:zsutpwpatterns-webapplication_dev

docker build -f ../ZsutPwPatterns.WebApplication.BlazorServer/Dockerfile.dev -t atomaszewski/application:zsutpwpatterns-webapplication_dev ..

docker images

docker image ls --filter label=stage=zsutpwpatterns-webapplication_dev_build

docker image prune --filter label=stage=zsutpwpatterns-webapplication_dev_build --force

docker push atomaszewski/application:zsutpwpatterns-webapplication_dev

docker images

::docker logout

pause
