using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using NUnit.Framework;

namespace Tests
{
    public class BsonDocumentTests
    {
        //to show nesting
        public BsonDocumentTests()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }

        [Test]
        public void EmptyDocument()
        {
            var document = new BsonDocument();
            Console.WriteLine(document);
        }

        [Test]
        public void AddElements()
        {
            var person = new BsonDocument
            {
                {"age", new BsonInt32(54)},
                {"surname",new BsonString("Kaltenyte") },
                {"IsAlive", true }
            };

            person.Add("firstName", new BsonString("Monika"));

            Console.WriteLine(person);
        }

        [Test]
        public void AddArrays()
        {
            var person = new BsonDocument();
            person.Add("address", 
                new BsonArray(new [] {"101 Road", "Unit 501"}));
          
            Console.WriteLine(person);
        }

        [Test]
        public void EmbeddeDocuments()
        {
            var person = new BsonDocument
            {
                {"contact", new BsonDocument
                {
                    {"phone", new BsonString("868140801") },
                    {"email", new BsonString("zmogus@zmogus.zmog") }
                } }
            };
            
            Console.WriteLine(person);
        }

        [Test]
        public void BsonValueConversions()
        {
            var person = new BsonDocument
            {
                {"age", 20 }
            };

            Console.WriteLine(person["age"].AsInt32+10);
        }

        [Test]
        public void ToBson()
        {
            var person = new BsonDocument
            {
                {"firstName", "Monika" }
            };

            var bson = person.ToBson();

            Console.WriteLine(BitConverter.ToString(bson));

            var deserializedPerson = BsonSerializer.Deserialize<BsonDocument>(bson);
            Console.WriteLine(deserializedPerson);    //cw+tab
        }
    }
}
