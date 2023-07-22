using eCommerce.API.Database;

var db = new eCommerceContext();

var usuarios = db.Usuarios!.ToList();

Console.WriteLine("========== LISTA DE USUÁRIOS ==========");
foreach (var usuario in usuarios)
{
    Console.WriteLine($" - {usuario.Nome}");
}
