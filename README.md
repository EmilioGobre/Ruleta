DildoStore
Starting SQL Server on a docker container
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$sa_password" -e "MSSQL_PID=Evaluation" -p 1433:1433 -v sqlvolume:/var/opt/mssql --rm --name mssql --hostname sqlpreview -d mcr.microsoft.com/mssql/server:2022-preview-ubuntu-22.04


Setting the conn string in secret Manager
sa_password="Passw0rd1"

dotnet user-secrets set "ConnectionStrings:RuletaContext" "Server=localhost; DataBase=Ruleta; User Id=sa; Password=$sa_password; TrustServerCertificate=True;"

dotnet ef database update --connection "Server=localhost; DataBase=Ruleta; User Id=sa; Password=$sa_password; TrustServerCertificate=True;"

"RuletaContext" : "Server=localhost; Database=Ruleta; User Id=sa; Password=PASSWORD_GOES_HERE; TrustServerCertificate=True"