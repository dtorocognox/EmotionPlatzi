using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmotionPlatzi.Web.Models
{
    public class EmoPicture
    {
        public int Id { get; set; }
        [Display(Name="Nombre")]
        public string Name { get; set; }
        [Required] //campo Path requerido
        [MaxLength(60, ErrorMessage = "La ruta supera el tamaño establecido")]
        public string Path { get; set; }

        public virtual ObservableCollection<EmoFace> Faces { get; set; }
    }
}