using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceContext();

#region Global Filter
Console.WriteLine("========== GLOBAL FILTER (FILTROS GLOBAIS) ==========");

//var usuarios = db.Usuarios!.IgnoreQueryFilters().ToList();
var usuarios = db.Usuarios!.ToList();
foreach (var usuario in usuarios)
{
    Console.WriteLine($"{usuario.Nome}");
}
#endregion

Console.WriteLine("========== DADOS TEMPORAIS (HISTÓRICO) ==========");

/*
// TEMPORALALL
var usuarioTemp = db.Usuarios!.TemporalAll().Where(a => a.Id == 2).OrderByDescending(a => EF.Property<DateTime>(a, "PeriodoInicial")).ToList();
*/

var AsOf = new DateTime(2023, 07, 22, 21, 11, 00);
var usuarioTemp = db.Usuarios!.TemporalAsOf(AsOf).Where(a => a.Id == 2).OrderByDescending(a => EF.Property<DateTime>(a, "PeriodoInicial")).ToList();
foreach (var usuario in usuarioTemp)
{
    Console.WriteLine($" - {usuario.Nome} - Mãe: {usuario.NomeMae}");
}
