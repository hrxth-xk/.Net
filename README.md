# .Net


Start SQL Server : docker compose up -d

Verify: docker ps

Use SQL: sqlcmd -S localhost,1433 -U sa -P examlyMssql@123

"ConnectionStrings": {
  "db": "Server=localhost,1433;Database=WeeklyDB;User Id=sa;Password=examlyMssql@123;TrustServerCertificate=True;"
}




docker run -e "ACCEPT_EULA=Y" \
-e "MSSQL_SA_PASSWORD=examlyMssql@123" \
-p 1433:1433 \
--name sqlserver \
-d mcr.microsoft.com/mssql/server:2022-latest



