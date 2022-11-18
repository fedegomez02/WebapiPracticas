using System.ComponentModel.DataAnnotations;

namespace WebApiFinalGomezFederico.Models
{
    public class Doctor
    {
        [Key]
        public int Doctor_NO { get; set; }

        public string Nombre { get; set; }

        public string Especialidad { get; set; }

        #region propiedades de navegacion
        [Required]
        public virtual Hospital Hospital { get; set; }

        #endregion

    }
}
