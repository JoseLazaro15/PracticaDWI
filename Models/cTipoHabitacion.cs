﻿using System.ComponentModel.DataAnnotations;

namespace PracticaV1.Models
{
    public class cTipoHabitacion
    {
        [Key]
        public int idTipo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
