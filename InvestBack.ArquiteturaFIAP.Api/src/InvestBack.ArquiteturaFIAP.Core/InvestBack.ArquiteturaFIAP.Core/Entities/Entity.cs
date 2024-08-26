using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace InvestBack.ArquiteturaFIAP.Core.Entities
{
    public class Entity
    {
        [BsonId] // Indica que esta propriedade é o _id no MongoDB
        [BsonRepresentation(BsonType.String)] // Opcional: Representa o Guid como string no MongoDB
        public Guid Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateOfChange { get; set; }

        [BsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        public Entity()
        {
            Id = new Guid();
        }

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
