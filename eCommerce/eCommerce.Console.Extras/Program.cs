﻿using eCommerce.API.Database;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("========== GLOBAL FILTER (FILTROS GLOBAIS) ==========");

var db = new eCommerceContext();
var usuarios = db.Usuarios!.IgnoreQueryFilters().ToList();
foreach (var usuario in usuarios)
{
    Console.WriteLine($"{usuario.Nome}");
}
