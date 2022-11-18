using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiFinalGomezFederico.Models
{
    public class Hospital
    {
        [Key]
        public int Hospital_Cod { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public int Num_Cama { get; set; }
        public int numeroTelefono { get; set; }

        #region propiedades de navegacion

        public virtual List<Doctor> Doctores { get; set; }  

        #endregion


    }
}
