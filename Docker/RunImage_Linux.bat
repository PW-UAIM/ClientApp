::docker login -u atomaszewski

docker ps -a

docker stop webapplication

docker ps 

docker images

::docker pull atomaszewski/application:zsutpwpatterns-webapplication_linux

docker run --name webapplication -p 5000:80 -it atomaszewski/application:zsutpwpatterns-webapplication_linux

pause

docker stop webapplication

docker rm webapplication

pause
