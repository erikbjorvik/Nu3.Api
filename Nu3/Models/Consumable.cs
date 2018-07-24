using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Nu3.Enums;

namespace Nu3Core.Models
{
    public class Consumable
    {
        [BsonElement("Id")]
        public ObjectId Id { get; set; }
        
        [BsonElement("Type")]
        public ConsumableType Type { get; set; }

		[BsonElement("MealCategory")]
        public MealCategory MealCategory { get; set; }
        
        [BsonElement("Name")]
        public string Name { get; set; }
        
        [BsonElement("Nutrients")]
        public Nutrients Nutrients { get; set; }

		[BsonElement("ImagePath")]
		public string ImagePath { get; set; }

        
    }
}