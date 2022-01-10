# MyEventBrite

### Table of Contents
- [Description](#description)
- [Requirements](#requirements)
- [How to use](#how-to-use)
- [Technology Stack](#technology-stack)
- [Authors](#authors)
- [Thank you](#thank-you)

## Description
#### Final Product
Our end goal is to build a web application similar to www.EventBrite.com that allows a user to organize events by creating online invitations, processing payments and track event related data. 
It also allows users to view and/or sign up for events. We plan to use Catalog, Identity, Cart and Order Microservices to build the Application. We plan to host the application on Docker containers.

#### Phase 1 
For Assignment 3a our goal was to build a back-end Events Catalog Service with seeded test data stored on local SQL database that lets the user test API options. The output is a key-value pair in JSON format. 
Examples include viewing picture associated to an event picture number or viewing event details by location or type of event.

#### Phase 2 
For Assignment 3b our goal was to build a back-end Cart service and Token service with integration to WebMvc providing our APIs a web interface where a user can explore our event catalog using event catalog API (built in phase-1). The user can then authenticate and place desired event item in the cart. 

#### Phase 3 

For Assignment 3c, the user can now complete the order using Order API for the items which were placed in the cart. The cart automatically empties using the messaging (Event bus) once the user is back to the main page. 


## Requirements
Software to be installed to run or test the application
- Visual Studio 2019 
- Postman https://www.getpostman.com/
- Docker Desktop https://www.docker.com/products/docker-desktop

## How to use
#### Demo
Here's a YouTube link showing a demo of the project:
#### Phase 1 (Assignment 3a)
https://www.youtube.com/watch?v=wXy-2fKhtzA

#### Phase 2&3 (Assignment 3b & 3c)
https://youtu.be/RsnPD3A0sTo

#### Steps for running our full project
1. Download or Clone the project from the Github and open in Visual Studio.
2. After opening the solution file (MyEventBrite.sln) Please make sure to start the project with Docker compose ( Please go to solutions explorer--> right click on the solution "MyEventBrite" --> Set startup projects--> Choose docker-compose in the drop down and click OK)
3. Please open the docker-compose.yml and replace the IP with your local machine's IP for the below "IdentityUrl" fields in the file.

   IdentityUrl: http://192.168.1.2:6701

   You can retrive your IP using [IPconfig](https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/ipconfig )

4. After setting the IdentityUrl fields, Please run the project using Docker-compose and make sure all the containers are running. 

### Website to test
##### [MyEventBrite](http://localhost:6821)

### APIs to test

[Swagger link to APIs](http://localhost:6820/swagger/index.html)

##### 1. [Pic controller](http://localhost:6820/api/pic/4)

##### 2. [Event Controller](http://localhost:6820/api/Event/eventitems?pageIndex=0&pageSize=5)

##### 3. [Filter using page reference](http://localhost:6820/api/Event/eventitems?pageIndex=0&pageSize=6)

##### 4. [Filter using event type, category and subcategory](http://localhost:6820/api/Event/eventitems/type/1/category/1/subCategory/4?pageIndex=0&pageSize=1)

##### 5. [Filter using location and event type, category, subcategory](http://localhost:6820/api/Event/EventItems/zipcode/1/type/1/category/1/subCategory/5?pageIndex=0&pageSize=6)

## Technology Stack
The technology stack used to build the application includes:
- Windows 10 Professional or better
- Visual Studio 2019 Community Edition or better
- C#
- .Net Core
- Docker Desktop
- Nuget Packages: 
  - Microsoft.EntityFrameworkCore (3.1.5)
  - Microsoft.EntityFrameworkCore.Relational (3.1.5)
  - Microsoft.EntityFrameworkCore.SqlServer (3.1.5)
  - Microsoft.EntityFrameworkCore.Tools (3.1.5)
  - StackExchange.Redis (2.1.58)
  - Newtonsoft.Json (12.0.3)
  - Autofac.Extensions.DependencyInjection(6.0.0)
  - System.IdentityModel.Tokens.Jwt (6.7.1)
  - Microsoft.AspNetCore.Authentication.JwtBearer (3.1.6)
  - Microsoft.AspNetCore.Mvc.NewtonsoftJson (3.1.6)
  - MassTransit(7.0.2)
  - MassTransit.AspNetCore(7.0.2)
  - MassTransit.Autofac (7.0.2)
  - MassTransit.RabbitMQ (7.0.2)


- For testing the APIs individually: Postman https://www.getpostman.com/
- For Messaging : RabbitMQ : http://localhost/15672
- For checking the order : Stripe https://stripe.com/
Use the below info to sign in to Stripe:
email: team5sdc7@gmail.com
password: KalAcademy@2020
full name: team5

## Authors
*** Tapasya Khatri *** Adarsha Kuthuru *** Hrudya Nair *** Vidhya Sambandan ***

## Thank You
We'd like to thank our instructor, Kal and all the TAs at KalAcademy for their excellent guidance and support. 
