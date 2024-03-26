// See https://aka.ms/new-console-template for more information
using LiteDB;
using LiteDb4LiliApp.Models;

Dictionary<string, Dictionary<string, Medicamento>> medicamentos;

static LiteDatabase CreateDB()
{
    LiteDatabase db = new LiteDatabase("LiliApp.db");
    return db;
}

static void Add(ref LiteDatabase db, Dictionary<string, Dictionary<string, Medicamento>> m)
{
    foreach (var tipoDeMedicina in m)
    {
        foreach (var med in tipoDeMedicina.Value)
        {
            db.GetCollection<Medicamento>().Insert(med.Value);
            db.Commit();
        }
    }
}



using (StreamReader file = File.OpenText(Path.Combine("Lili_demo.json")))
{
    medicamentos = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Medicamento>>>(file.ReadToEnd());
}

LiteDatabase db = CreateDB();
Add(ref db, medicamentos);
//Console.WriteLine("Done!");



