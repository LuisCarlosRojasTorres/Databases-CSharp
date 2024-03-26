namespace LiteDb4LiliApp.Models
{
    public class TypeOfMedicamento
    {
        public string TipoDeMedicamento { get; set; }
        public List<string> ListaDeMedicamentos { get; set; }

        public TypeOfMedicamento() 
        {
            this.TipoDeMedicamento = null;
            this.ListaDeMedicamentos = null;
        }
        public TypeOfMedicamento(string t, List<string> l) 
        {
            this.TipoDeMedicamento = t;
            this.ListaDeMedicamentos = l;
        }

    }
}
