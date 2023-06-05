docker login -u majumi -p uaimrzadzi

docker stop clientapp

docker pull majumi/clientapp:application

docker run --name clientapp -p 5100:5100 -it majumi/clientapp:application

pause

docker stop clientapp

docker rm clientapp

pause
