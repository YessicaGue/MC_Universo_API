﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class RegistroOchoAccionesCatalogoOchoAcciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int RegistroOchoAccionesId { get; set; }
        [ForeignKey("RegistroOchoAccionesId")]
        public virtual RegistroOchoAcciones RegistroOchoAcciones { get; set; } = default!;

        public required int CatalogoOchoAccionesId { get; set; }
        [ForeignKey("CatalogoOchoAccionesId")]
        public virtual CatalogoOchoAcciones CatalogoOchoAcciones { get; set; } = default!;

    }
}
