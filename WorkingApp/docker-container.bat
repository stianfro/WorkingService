docker build -t workingservice .
docker tag workingservice sharparchitect/workingservices:latest
docker push sharparchitect/workingservices:latest