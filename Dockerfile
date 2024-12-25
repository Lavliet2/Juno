# Используем официальный образ PostgreSQL
FROM postgres:15-alpine

# Устанавливаем переменные окружения для базы данных
ENV POSTGRES_DB=Juno_Demo \
    POSTGRES_USER=dgfAdmin \
    POSTGRES_PASSWORD=Landmark123

# Точка входа остаётся по умолчанию, т.к. базовый образ уже настроен
