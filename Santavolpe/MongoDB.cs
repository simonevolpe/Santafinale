using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Santavolpe
{
    public class MongoDB : IDataBase
    {
        private IMongoDatabase database
        {
            get
            {
                return MongoConnection.Instance.Database;
            }
        }
        public IEnumerable<Order> GetAllCategoriesOreders()
        {
            IMongoCollection<Order> categoryCollection = database.GetCollection<Order>("order");
            throw new NotImplementedException();
        }

        public IEnumerable<Toy> GetAllToys()
        {
            IMongoCollection<Toy> toyCollection = database.GetCollection<Toy>("toys");
            return toyCollection.Find(new BsonDocument()).ToList();
        }
        public Order GetOrder(string id)
        {
            IMongoCollection<Order> orderCollection = database.GetCollection<Order>("orders");
            return orderCollection.Find(_ => _.ID == id).FirstOrDefault();
        }
        /*     
        public Order GetOrder(Order order)
        {
            IMongoCollection<Order> OrderCollection = database.GetCollection<Order>("order");
            return OrderCollection.Find(_ => _.Kid == order.Kid && _.Status == order.Status && _.Toys == order.Toys && _.Toys == order.Toys && _.requestDate == order.requestDate).FirstOrDefault();
        }
        */
        public User GetUser(User user)
        {
            IMongoCollection<User> userCollection = database.GetCollection<User>("user");
            return userCollection.Find(_ => _.ScreenName == user.ScreenName && _.Email == user.Email && _.IsAdmin == user.IsAdmin && _.Password == user.Password && _.PasswordClearText == user.PasswordClearText).FirstOrDefault();
        }

        public Toy GetToy(string id)
        {
            IMongoCollection<Toy> toyCollection = database.GetCollection<Toy>("toys");
            return toyCollection.Find(_ => _.ID == id).FirstOrDefault();
        }

        public bool InsertOrder(Order order)
        {
            IMongoCollection<Order> categoryCollection = database.GetCollection<Order>("order");
            try
            {
                categoryCollection.InsertOne(order);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertUser(User user)
        {
            IMongoCollection<User> userCollection = database.GetCollection<User>("user");
            try
            {
                userCollection.InsertOne(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateOrder(Order order)
        {
            IMongoCollection<Order> orderCollection = database.GetCollection<Order>("order");
            var filter = Builders<Order>.Filter.Eq("_id", ObjectId.Parse(order.ID));
            var update = Builders<Order>.Update
                .Set("kid", order.Kid)
                .Set("status", order.Status)
                .Set("toys", order.Toys)
                .Set("requestDate", order.requestDate);
            try
            {
                orderCollection.UpdateOne(filter, update);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateUser(User user)
        {
            IMongoCollection<User> UserCollection = database.GetCollection<User>("user");
            var filter = Builders<User>.Filter.Eq("_id", ObjectId.Parse(user.ID));
            var update = Builders<User>.Update
                .Set("screenname", user.ScreenName)
                .Set("email", user.Email)
                .Set("isAdmin", user.IsAdmin)
                .Set("password", user.Password)
                .Set("password_clear_text", user.PasswordClearText);

            try
            {
                UserCollection.UpdateOne(filter, update);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
