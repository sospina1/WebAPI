using System.ComponentModel.DataAnnotations;

namespace WebAPI.DAL.Entities
{
    public class AuditBase
    {

        [Key] // PK
        [Required] // Significa que este campo sera obligatorio 
           public virtual Guid id { get; set; } // Esta sera el PK de todas las tablas 

           public virtual DateTime? CreatedDate { get; set; } // para guardar todo registro nuevo con su date 

           public virtual DateTime? ModifiedDate { get; set; } // para guardar todo registro que se modifico con su date

    }
}
