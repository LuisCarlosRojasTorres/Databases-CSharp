namespace LiteDb4LiliApp.Models
{
    public class DbMedicamento
    {
        public Medicamento Medicamento { get; set; }
        public string TipoDeMedicamento { get; set; }
        public string Nome { get; set; }

        public DbMedicamento() { }
        public DbMedicamento(string n, string t, Medicamento m) 
        {
            this.Nome = n;
            this.TipoDeMedicamento = t;
            this.Medicamento = m;
        }
    }
}
