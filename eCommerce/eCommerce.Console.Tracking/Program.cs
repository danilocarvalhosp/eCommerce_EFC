
using eCommerce.API.Database;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceContext();

// TRACKING
var usuario01 = db.Usuarios.FirstOrDefault(a => a.Id == 1);
usuario01!.Nome = "José Ribeiro da Silva Costa";
db.SaveChanges();

// NOTRACKING
var usuario02 = db.Usuarios.AsNoTracking().FirstOrDefault(a => a.Id == 1);
usuario01!.Nome = "José Ribeiro da Silva Costa";
db.Update(usuario02);
db.SaveChanges();


void TrackingNoTracking()
{
    /*
    var usuario01 = db.Usuarios.FirstOrDefault(a => a.Id == 1);
    usuario01!.Nome = "José Ribeiro da Silva Costa";
    db.SaveChanges();
    */

    var usuario01 = db.Usuarios.AsNoTracking().FirstOrDefault(a => a.Id == 1);
    usuario01!.Nome = "José Ribeiro da Silva Costa";
    db.Update(usuario01);
    db.SaveChanges();
}
