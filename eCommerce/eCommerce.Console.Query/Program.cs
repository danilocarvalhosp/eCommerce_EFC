using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceContext();

var usuarios = db.Usuarios!.ToList();

/*
Console.WriteLine("========== LISTA DE USUÁRIOS ==========");
foreach (var usuario in usuarios)
{
    Console.WriteLine($" - {usuario.Nome}");
}

Console.WriteLine("BUSCAR UM ÚNICO USUÁRIO");
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

// WHERE
Console.WriteLine("========== LISTA DE USUÁRIOS (WHERE) ==========");
var usuariosList = db.Usuarios!.Where(a => a.Nome.Contains("Danilo") || EF.Functions.Like(a.Nome, "D%")).ToList();
foreach (var usuario in usuariosList)
{
    Console.WriteLine($" - {usuario.Nome}");
}

Console.WriteLine("========== LISTA DE USUÁRIOS (ORDER) ==========");
// ORDERBY
var usuariosListOrder = db.Usuarios!.OrderBy(a => a.Nome).ToList();
Console.WriteLine();
foreach (var usuario in usuariosListOrder)
{
    Console.WriteLine($" - {usuario.Nome}");
}

// ORDERBYDESCENDING
var usuariosListOrder2 = db.Usuarios!.OrderByDescending(a => a.Nome).ToList();
Console.WriteLine();
foreach (var usuario in usuariosListOrder2)
{
    Console.WriteLine($" - {usuario.Nome}");
}

// THENBY
var usuariosListOrder3 = db.Usuarios!.OrderBy(a => a.Sexo).ThenBy(a => a.Nome).ToList();
Console.WriteLine();

foreach (var usuario in usuariosListOrder3)
{
    Console.WriteLine($" - {usuario.Nome}");
}


// THENBYDESCENDING
var usuariosListOrder4 = db.Usuarios!.OrderBy(a => a.Sexo).ThenByDescending(a => a.Nome).ToList();
Console.WriteLine();

foreach (var usuario in usuariosListOrder4)
{
    Console.WriteLine($" - {usuario.Nome}");
}

Console.WriteLine("========== LISTA DE USUÁRIOS (INCLUDE) ==========");

// INCLUDE
var usuariosListInclude = db.Usuarios!.Include(a => a.Contato).Include(a => a.EnderecosEntrega).Include(a => a.Departamentos).ToList();
Console.WriteLine();
foreach (var usuario in usuariosListInclude)
{
    Console.WriteLine($" {usuario.Nome} - TEL: {usuario.Contato!.Telefone} - QT END: {usuario.EnderecosEntrega!.Count} - QT DPTO: {usuario.Departamentos!.Count}");

    foreach (var endereco in usuario.EnderecosEntrega)
    {
        Console.WriteLine($" -> {endereco.NomeEndereco}: {endereco.CEP} - {endereco.Estado} - {endereco.Bairro} -{endereco.Endereco}");
    }
    Console.WriteLine();

Console.WriteLine("========== LISTA DE CONTATOS (THENINCLUDE) ==========");

// THENINCLUDE
var contatos = db.Contatos!.Include(a => a.Usuario).ThenInclude(u => u.EnderecosEntrega).Include(a => a.Usuario).ThenInclude(e => e.Departamentos).ToList();
Console.WriteLine();
foreach (var contato in contatos)
{
    Console.WriteLine($"- {contato.Telefone} -> {contato.Usuario!.Nome} - QT END: {contato.Usuario.EnderecosEntrega!.Count} - QT DPTO: {contato.Usuario.Departamentos!.Count}");
}

Console.WriteLine("========== LISTA DE CONTATOS (AUTOINCLUDE) ==========");

// AUTOINCLUDE
var usuariosAutoInclude = db.Usuarios!.IgnoreAutoIncludes().ToList();
Console.WriteLine();
foreach (var usuario in usuariosAutoInclude)
{
    Console.WriteLine($"NOME: {usuario.Nome} - TEL: {usuario.Contato?.Telefone}");
}
// EXPLICT LOAD - Carregamento Explicito
db.ChangeTracker.Clear();

Console.WriteLine("========== CARREGAMENTO EXPLÍCITO ==========");

var usuarioExplicitLoad = db.Usuarios!.IgnoreAutoIncludes().FirstOrDefault(a => a.Id == 1) ;
Console.WriteLine($"NOME: {usuarioExplicitLoad!.Nome} - TEL: {usuarioExplicitLoad!.Contato?.Telefone} - END: {usuarioExplicitLoad.EnderecosEntrega?.Count}");

db.Entry(usuarioExplicitLoad).Reference(a => a.Contato).Load();
db.Entry(usuarioExplicitLoad).Collection(a => a.EnderecosEntrega!).Load();
Console.WriteLine($"NOME: {usuarioExplicitLoad!.Nome} - TEL: {usuarioExplicitLoad!.Contato!.Telefone} - END: {usuarioExplicitLoad.EnderecosEntrega?.Count}");

var enderecos = db.Entry(usuarioExplicitLoad).Collection(a => a.EnderecosEntrega!).Query().Where(a => a.Estado == "SP").ToList();
foreach (var endereco in enderecos)
{
    Console.WriteLine($" -- {endereco.NomeEndereco}: {endereco.Estado} {endereco.Cidade} - {endereco.Endereco}, {endereco.Complemento}");
}
// LAZY LOADING - Carregamento Preguiçoso
Console.WriteLine("========== CARREGAMENTO PREGUIÇOSO ==========");
db.ChangeTracker.Clear();

var usuarioLazyLoad = db.Usuarios!.Find(1);
Console.WriteLine($"- NOME: {usuarioLazyLoad!.Nome} - END: {usuarioLazyLoad.EnderecosEntrega?.Count}");

// SPLIT QUERY - QUERY DIVIDIDA
db.ChangeTracker.Clear();

Console.WriteLine("========== QUERY DIVIDIDA ==========");
var usuarioSplitQuery = db.Usuarios!.AsSingleQuery().Include(a => a.EnderecosEntrega).FirstOrDefault(a => a.Id == 1);
Console.WriteLine($"- NOME: {usuarioSplitQuery!.Nome} - END: {usuarioSplitQuery.EnderecosEntrega?.Count}");

// TAKE - Pegar uma quantidade definida de registros
// SKIP - Pular uma quantidade definida de registros

Console.WriteLine("========== TAKE E SKIP ==========");
var usuariosSkipTake = db.Usuarios!.Skip(1).Take(2).ToList();
foreach (var usuario in usuariosSkipTake)
{
    Console.WriteLine($"{usuario.Nome}");
}

// SELECT
Console.WriteLine("========== SELECT ==========");
var usuarioSelect = db.Usuarios!.Where(a => a.Id > 2).Select(a => new { Id = a.Id, Nome = a.Nome, NomeMae = a.NomeMae}).ToList();
foreach (var usuario in usuarioSelect)
{
    Console.WriteLine($"- COD: {usuario.Id} - NOME: {usuario.Nome} - MÃE: {usuario.NomeMae}");
}
*/

db.ChangeTracker.Clear();
Console.WriteLine("========== EXECUÇÃO DE SQL ==========");

var nome = new SqlParameter("@nome", "%Sim%");
var usuariosSqlRaw = db.Usuarios!.FromSqlRaw($"SELECT * FROM [Usuarios] WHERE Nome like @nome", nome).IgnoreAutoIncludes().ToList();
foreach (var usuario in usuariosSqlRaw)
{
    Console.WriteLine($"- COD: {usuario.Id} - NOME: {usuario.Nome} - MÃE: {usuario.NomeMae}");
}

