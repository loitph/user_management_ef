#!/bin/bash

CONTAINER_NAME="user_management_ef"

if [ "$(docker ps -aq -f name=$CONTAINER_NAME)" ]; then
    echo "Container exists. Starting container..."
    docker start $CONTAINER_NAME
else
    echo "Container does not exist. Creating container..."
    docker compose up -d
fi