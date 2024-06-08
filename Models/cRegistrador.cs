﻿using System.ComponentModel.DataAnnotations;

namespace PracticaV1.Models
{
    public class cRegistrador
    {
        [Key]
        public int idRegistrador { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string documento { get; set; }
        public string telefono { get; set; }
        public string observacion { get; set; }
    }
}
