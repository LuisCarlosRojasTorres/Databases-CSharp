namespace LiteDb4LiliApp.Models
{
    public class Medicamento
    {
        public string NombreFarmacologico { get; set; }

        public string NombreComercial { get; set; }


        public string Grupo { get; set; }

        public string PrincipioActivo { get; set; }

        public string Accion { get; set; }

        public List<string> Presentacion { get; set; }

        public string Reconstitucion { get; set; }

        public List<string> Cuidados { get; set; }

        public List<string> Dosis { get; set; }
    }
}
