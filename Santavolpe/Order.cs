﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santavolpe
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }

        [BsonElement("kid")]
        public string Kid { get; set; }

        [BsonElement("status")]
        public int Status { get; set; }

        [BsonElement("toys")]
        public List<Toy> Toys { get; set; }

        [BsonElement("requestDate")]
        public DateTime requestDate { get; set; }
    }
}