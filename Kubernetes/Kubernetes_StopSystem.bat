echo off
kubectl delete service clientapp
kubectl delete service mechanicapp
kubectl delete service clientappservice
kubectl delete service mechanicappservice
kubectl delete service carsdataservice
kubectl delete service clientsdataservice
kubectl delete service mechanicsdataservice
kubectl delete service visitsdataservice

kubectl delete deployment clientapp-deploy
kubectl delete deployment mechanicapp-deploy
kubectl delete deployment clientappservice-deploy
kubectl delete deployment mechanicappservice-deploy
kubectl delete deployment carsdataservice-deploy
kubectl delete deployment clientsdataservice-deploy
kubectl delete deployment mechanicsdataservice-deploy
kubectl delete deployment visitsdataservice-deploy
pause

echo on
kubectl get deployments
kubectl get services
kubectl get pods
pause
