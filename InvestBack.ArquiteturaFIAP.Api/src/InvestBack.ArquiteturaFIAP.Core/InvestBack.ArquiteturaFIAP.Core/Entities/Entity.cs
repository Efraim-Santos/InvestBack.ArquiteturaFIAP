using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestBack.ArquiteturaFIAP.Core.Entities
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateOfChange { get; set; }

        [NotMapped]
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
