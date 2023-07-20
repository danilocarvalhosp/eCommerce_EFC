using eCommerce.Office;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceOfficeContext();

#region Many-To-Many > 2x One-To-Many = EFCore <= 3.1
var resultado = db.Setores!.Include(a => a.ColaboradoresSetores).ThenInclude(a => a.Colaborador);

foreach ( var setor in resultado)
{
    Console.WriteLine(setor.Nome);
    foreach ( var colabSetor in setor.ColaboradoresSetores)
    {
        Console.WriteLine(" - " + colabSetor.Colaborador.Nome);
    }
}
#endregion

#region 

var resultadoTurma = db.Colaboradores.Include(a => a.Turmas);

foreach (var colab in resultadoTurma)
{
    Console.WriteLine(colab.Nome);
    foreach (var turma in colab.Turmas)
    {
        Console.WriteLine("- " + turma.Nome);
    }
}

#endregion