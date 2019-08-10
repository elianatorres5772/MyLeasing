using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Document { get; set; }
        //COmment

        [Required]//varible requerida 
        [MaxLength(50)]//maxiimo 
        [Display(Name = "First Name")]//como aparece el nombre
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [MaxLength(20)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(20)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        public string Address { get; set; }

        // SE  PROPIEDADES DE LECTURA 


        public string FullName => $"{FirstName}{LastName}"; //es una propiedad solo lectura no devuelve nada en bases de datos
        public string FullNameWithDocument => $"{FirstName}{LastName} - {Document}";

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }

    }
}
