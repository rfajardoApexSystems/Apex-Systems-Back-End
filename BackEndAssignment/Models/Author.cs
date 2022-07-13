using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndAssignment.Models
{
    public class Author : BaseEntityModel 
    {

        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
