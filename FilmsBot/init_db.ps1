docker run --name postgres-bots -p 5432:5432 -e POSTGRES_USER=ipilot -e POSTGRES_PASSWORD=local_postgres -e POSTGRES_DB=postgres -e PGDATA=/var/lib/postgresql/data/pgdata -d -v C:\LocalDb\postgres:/var/lib/postgresql/data postgres
[Console]::ReadKey()