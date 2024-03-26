// See https://aka.ms/new-console-template for more information
using LiteDB;
using LiteDb4LiliApp.Models;
using System.Xml.Linq;

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
        db.GetCollection<TypeOfMedicamento>().Insert(new TypeOfMedicamento(tipoDeMedicina.Key, new List<string>(tipoDeMedicina.Value.Keys)));
        db.Commit();        
    }

    foreach (var tipoDeMedicina in m)
    {
        foreach (var dummyMedicamento in tipoDeMedicina.Value)
        {
            db.GetCollection<DbMedicamento>().Insert(new DbMedicamento(n: dummyMedicamento.Key ,t:tipoDeMedicina.Key, m: dummyMedicamento.Value ));
            db.Commit();
        }
    }
}

static DbMedicamento GetMedicamentoByName(ref LiteDatabase db, string name)
{
    if (db.CollectionExists("DbMedicamento"))
    {
        DbMedicamento foundOne = db.GetCollection<DbMedicamento>().FindOne(x => x.Nome == name);
        if (foundOne != null)
        {
            return foundOne;            
        }
        else
        {
            return null;
        }
    }
    return null;
}



using (StreamReader file = File.OpenText(Path.Combine("Lili_demo.json")))
{
    medicamentos = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Medicamento>>>(file.ReadToEnd());
}

LiteDatabase db = CreateDB();
//Add(ref db, medicamentos);
var dummy = GetMedicamentoByName(ref db, "KETOROLACO");
Console.WriteLine("Done!");



