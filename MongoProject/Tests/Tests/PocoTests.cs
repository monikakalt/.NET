using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Attributes;
using NUnit.Framework;

namespace Tests
{
    public class PocoTests
    {
        public PocoTests() //ctor+tab
        {
            JsonWriterSettings.Defaults.Indent = true;//indention settings for json constructor
        }

        public class Person
        {
            
            public int Age { get; set; }
            public string Name { get; set; }

            [BsonElement("New")]
            public string Old { get; set; }

            public List<string> Address = new List<string>();

            [BsonIgnoreIfNull]
            public Contact Contact = new Contact();
        }

        public class Contact
        {
            public string Email { get; set; }
            public string Phone { get; set; }
        }


        [Test]
        public void Automatic()
        {
            var person = new Person
            {
                Age = 20,
                Name = "Monika",
                
            };
            person.Address.Add("101 Road");
            person.Address.Add("505 Road");
            person.Contact.Email="zmogus@zmogus.zmog";
            person.Contact.Phone="333333";
            

            Console.WriteLine(person.ToJson());
        }
    }
}
