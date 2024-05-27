namespace MC_Universo_API.Models.Precandidaturas
{
    public class ApoyoPrecandidaturaViewModel
    {
        public required int PerfilId { get; set; }

        public required int TipoPrecandidaturaId { get; set; }


        public string? Email { get; set; }

        public string? NumeroTelefono { get; set; }

        public string? ClaveElector { get; set; }

        public required string FormularioRellenadoJSON { get; set; }

        public bool? EstaInteresadoInformacionAdicional { get; set; }


        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
