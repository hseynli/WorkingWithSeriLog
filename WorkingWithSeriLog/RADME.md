# This project illustrates the working of SeriLog
# Please don't use this kind of project structure in real projects
# This is just for learning purposes

# Download Seq library from docker
docker run -d --restart unless-stopped --name seq -e ACCEPT_EULA=Y -v 'D:\Projects\VS Projects\WorkingWithSeriLog\logs:/data' -p 8081:80 datalust/seq:latest

# Please note that the above command must run in the l

# Seq url: 
http://localhost:8081/#/events?range=1d

