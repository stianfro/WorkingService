docker build -t workingservice ./WorkingApp
docker tag workingservice sharparchitect/workingservices:latest
docker push sharparchitect/workingservices:latest