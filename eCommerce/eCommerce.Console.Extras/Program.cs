﻿using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceContext();

var usuarioNovo = db.Usuarios!.Find(2);
usuarioNovo.NomeMae = "Joana Rodrigues de Almeida Santana";
db.SaveChanges();

Console.WriteLine("========== GLOBAL FILTER (FILTROS GLOBAIS) ==========");

//var usuarios = db.Usuarios!.IgnoreQueryFilters().ToList();
var usuarios = db.Usuarios!.ToList();
foreach (var usuario in usuarios)
{
    Console.WriteLine($"{usuario.Nome}");
}

