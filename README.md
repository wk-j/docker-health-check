## Health Check

- https://localhost:8001/api/values

## Start PostgreSQL

```bash
docker-compose stop postgres
docker-compose rm -f postgres
docker-compose up -d --no-deps postgres
```