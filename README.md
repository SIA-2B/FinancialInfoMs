Setup:
1) Create a network for the financialinfoms container and mongodb container:
   - docker network create financial-net

2) Run the docker-compose file:
   - docker-compose -p financialinfo up --build

Create a database:
3) Create a mongodb container and attach it to the network:
   - docker run --name mongodb -d --network financial-net mongo:4.0

4) Enter to the mongodb container (running):
   - docker exec -it "container" sh

5) Create the database:
   - use Financialdb

6) Create the users collection: and populate it:
   - db.Users.insertMany(["here the content from users_db_data"])

7) Create the UsersBills collection: and populate it:
   - db.UsersBills.insertMany(["here the content from usersbills_db_data"])

Test the api:
9) Use postman or insomnia to test: 
   - GET http://localhost:5136/financialms/bills/1234567890