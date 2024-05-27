namespace MC_Universo_API.Models.Precandidaturas
{
    public class PerfilPrecandidaturaViewModel
    {
        public required int PerfilId { get; set; }

        public required int TipoPrecandidaturaId { get; set; }


        public string? Alias { get; set; }

        public string? Descripcion { get; set; }

        public string? FotoPerfil { get; set; }

        public Guid? GuidInvitacionCoadministracion { get; set; }
        public string? LigaInvitacionCoadministracion { get; set; }

        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
