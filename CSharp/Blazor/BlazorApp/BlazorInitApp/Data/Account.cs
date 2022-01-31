using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorInitApp.Data
{
    [BsonIgnoreExtraElements]
    public class Account
    {
        [DataMember]
        public ObjectId _id { get; set; }

        [DataMember]
        public string fullname { get; set; }

        [DataMember]
        public string username { get; set; }

        [DataMember]
        public bool gender { get; set; }
    }
}