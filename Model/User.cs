﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CMS_App.Model
{
    public class User
    {
        [BsonId]
        // standard BSonId generated by MongoDb
        public ObjectId InternalId { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        public int UserType { get; set; }

        public int UserStatus { get; set; }

        public DateTime UserCreated { get; set; } = DateTime.Now;

        public DateTime UserModified { get; set; }        
    }
}