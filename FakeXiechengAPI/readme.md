### 拉取 image

``
docker pull mcr.microsoft.com/mssql/server
``

### 配置 mssql 的 container

这里的用户名就是 SA，这里的密码就是password 里面设置的密码

``
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=PASSWORD123!' -p 1433:1433 -d mcr.microsoft.com/mssql/server
``

