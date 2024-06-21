This Application was built in dotnet core 8.0.

How to run this application
1.) Clone or Downloan the zip file from either master branch or feature/blog branch.
2.) Build the clone file to add necessary dependencies
3.) Run migration commands to create your database ensure you change to your own database set up in the appsetting.json before running migration
commands to run using package manager console
i add-migration
ii update-database
4.) Run the solution.


xUnit was use to write the unit test and it was located in a folder called UnitTest

Docker Set up.
You can change it to your dockerfile set-up
version: '3.8'

services:
  db:
    image: postgres:15
    environment:
      POSTGRES_USER: localhost
      POSTGRES_PASSWORD: Password@123
      POSTGRES_DB: BlogTaskDB
    networks:
      - mynetwork
    ports:
      - "5432:5432"

  app:
    image: bloggingsystemimage
    depends_on:
      - db
    environment:
      - CONNECTION_STRING=Host=db;Port=5432;Username=postgres;Password=Password@123;Database=BlogTaskDB
    networks:
      - bloggingsystem:dev
    ports:
      - "32771:8080"

networks:
  mynetwork:
