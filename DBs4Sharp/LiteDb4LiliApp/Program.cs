// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using LiteDb4LiliApp.Models;

Dictionary<string, Dictionary<string, Medicamento>> medicamentos;

using (StreamReader file = File.OpenText(Path.Combine("Lili_demo.json")))
{
    medicamentos = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Medicamento>>>(file.ReadToEnd());
}
Console.WriteLine("Done!");



