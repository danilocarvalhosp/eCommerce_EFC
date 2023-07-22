using eCommerce.API.Database;
using eCommerce.Models;

var db = new eCommerceContext();

var usuarios = db.Usuarios!.ToList();

Console.WriteLine("========== LISTA DE USUÁRIOS ==========");
foreach (var usuario in usuarios)
{
    Console.WriteLine($" - {usuario.Nome}");
}

Console.WriteLine("BUSCAR UM ÚNICO USUÁRIO");
/*
// FIND
var usuario01 = db.Usuarios!.Find(2);
Console.WriteLine($" CÓDIGO: {usuario01!.Id} - NOME: {usuario01!.Nome}");

// FIRST
var usuario02 = db.Usuarios!.Where(a => a.Email == "cassia@gmail.com").First();
Console.WriteLine($" CÓDIGO: {usuario02!.Id} - NOME: {usuario02!.Nome}");

// FIRSTORDEFAULT
var usuario05 = db.Usuarios!.Where(a => a.Email == "cassia@gmail.com").FirstOrDefault();
if (usuario05 == null)
{
    Console.WriteLine("Usuário não encontrado!!!");
}
else
{
    Console.WriteLine($" CÓDIGO: {usuario02!.Id} - NOME: {usuario02!.Nome}");
}

// LAST
var usuario03 = db.Usuarios!.OrderBy(a => a.Id).Last();
Console.WriteLine($" CÓDIGO: {usuario03!.Id} - NOME: {usuario03!.Nome}");

// LASTORDEFAULT
var usuario04 = db.Usuarios!.Where(a => a.Email == "cassia@gmail.com").LastOrDefault();
if (usuario04 == null)
{
    Console.WriteLine("Usuário não encontrado!!!");
}
else
{
    Console.WriteLine($" CÓDIGO: {usuario04!.Id} - NOME: {usuario04!.Nome}");
}
*/

// SINGLE
var usuario01 = db.Usuarios!.Single(a => a.Email == "danilo@gmail.com");
Console.WriteLine($" CÓDIGO: {usuario01!.Id} - NOME: {usuario01!.Nome}");

// SINGLE
var usuario02 = db.Usuarios!.SingleOrDefault(a => a.Email == "danilosp@gmail.com");
if (usuario02 == null)
{
    Console.WriteLine("Usuário não encontrado!!!");
}
else
{
    Console.WriteLine($" CÓDIGO: {usuario02!.Id} - NOME: {usuario02!.Nome}");
}

// COUNT
var count = db.Usuarios!.Where(a => a.Nome.Contains("o")).Count();
Console.WriteLine($"NÚMERO DE USUÁRIOS QUE CONTÉM A LETRA 'O' EM SEU NOME: {count}");

// MAX
var max = db.Usuarios!.Max(a => a.Nome);
Console.WriteLine($"VALOR MÁXIMO: {max}");

// MIN
var min = db.Usuarios!.Min(a => a.Nome);
Console.WriteLine($"VALOR MÍNIMO: {min}");
