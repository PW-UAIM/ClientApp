echo off
kubectl delete service clientapp
kubectl delete service clientappservice
kubectl delete service carsdataservice
kubectl delete service clientsdataservice
kubectl delete service visitsdataservice

kubectl delete deployment clientapp-deploy
kubectl delete deployment clientappservice-deploy
kubectl delete deployment carsdataservice-deploy
kubectl delete deployment clientsdataservice-deploy
kubectl delete deployment visitsdataservice-deploy
pause

echo on
kubectl get deployments
kubectl get services
kubectl get pods
pause
