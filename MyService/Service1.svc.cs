using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            using(var db = new DataBaseContext())
            {
                int counter = 0;
                int sCounter = 100;
                for(int i = 0; i < 5000; i++)
                {
                    counter++;
                    var user = new User { Username = Faker.NameFaker.Name(), Password = "Loco", EmailAddress = Faker.InternetFaker.Email() };
                    db.Users.Add(user);

                    if (counter == sCounter)
                    {
                        db.SaveChanges();
                        sCounter += 100;
                    }
                }
                db.SaveChanges();

            }
            return "Done";
           
        }

        public int Register()
        {
            using(var db = new DataBaseContext())
            {
                var user = new User { Username = Faker.NameFaker.Name(), Password = "Loco", EmailAddress = Faker.InternetFaker.Email() };
                db.Users.Add(user);
                db.SaveChanges();
                return user.UserId;
            }

           
        }

        public User GetUser(int Id)
        {

           User query = null;
            using (var db = new DataBaseContext())
            {
                db.Configuration.ProxyCreationEnabled = false;//allows virtual properties in entity framework models
                var u = db.Users.Where(s => s.UserId == Id);
                query = u.FirstOrDefault<User>();
            }
            return query;
        }

        public List<User> GetUsers()
        {
            List<User> query = null;
            using (var db = new DataBaseContext())
            {
                db.Configuration.ProxyCreationEnabled = false;//allows virtual properties in entity framework models
                query = db.Users.ToList<User>();
    
            }
           
        return query;
           
           

        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
