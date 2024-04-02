namespace LiteDb4LiliApp.Models
{
    public class Medicamento
    {
        public string NombreFarmacologico { get; set; } // 1

        public string NombreComercial { get; set; } // 2 

        public string Grupo { get; set; } // 3

        public string PrincipioActivo { get; set; } // 4

        public string Accion { get; set; } // 5

        public string PH { get; set; } // 6

        public string Osmolaridad { get; set; } // 7

        public List<string> Riesgo { get; set; } // 8

        public List<string> Conservacion { get; set; } // 9

        public string Fotosensible { get; set; } // 11

        public List<string> Presentacion { get; set; } // 12

        public List<string> ViaDeAdministracion { get; set; } // 13

        public List<string> Dosis { get; set; } // 14

        public string Reconstitucion { get; set; } // 15

        public string Dilución { get; set; } // 16

        public string TiempoDeInfusion { get; set; } // 17

        public List<string> Cuidados { get; set; } // 18
    }
}
