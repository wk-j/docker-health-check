## Health Check

- https://localhost:8001/api/values

## Start PostgreSQL

```bash
docker-compose stop postgres
docker-compose rm -f postgres
docker-compose up -d --no-deps postgres
```

## Health Check

```bash
docker inspect (docker-compose ps -q web-api) | grep Status
```