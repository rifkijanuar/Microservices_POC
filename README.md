### .NET Microservice Using Docker And Ocelot
## Requirements
        - Docker Desktop
        - .NET Core 6 SDK
        - Sql Server
        
## Install Docker
        - Download file docker in this URL link Docker and Install

## Step-by-step implementation of microservices
        - Create a Blank Empty solution using a visual studio.
        - We Create 3 service for example
                -ProductMicroservice
                -UserMicroservice
                -TransactionMicroservice
        - Install the following NuGet packages.
        - Execute the following command in the package manager console to create migration and create the database.
                - add-migration "Initial"
                - update-database
        - Create a Docker file for ProductMicroservice
        - Create a Docker file for UserMicroservice
        - Create a Docker file for TransactionMicroservice
        - Create a docker-compose.yml for ProductMicroservice
        - Create a docker-compose.yml for UserMicroservice
        - Create a docker-compose.yml for TransactionMicroservice
        - Open Docker Desktop and you can see inside that there are three images created and is in running mode
        - Open the Container section and there you will see your three images running inside a container with their individual port number
        - Use the following URLs to check your microservices functionality which is running inside a docker container
                - Product Service

                - User Service

                - Transaction Service

## Implementation of Ocelot API Gateway
        - Create new project for Implementation of Ocelot API Gateway

        - Install Ocelot NuGet Package.
        
        - Project Structure:

        - Create an ocelot.json file for routing.

        - Configure the ocelot.json file inside Program.cs class and register services related to that.

        - After running your Ocelot API Gateway project, you will see this swagger UI
