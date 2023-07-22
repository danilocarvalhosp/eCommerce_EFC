using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Console.Query.Config;


namespace eCommerce.Models
{
    public class Usuario
    {
        private readonly Action<object, string> LazyLoader;

        public Usuario()
        {
            
        }

        public Usuario(Action<object, string> lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Sexo { get; set; }
        public string RG { get; set; } 
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        public string? NomePai { get; set; }
        public string SituacaoCadastro { get; set; } = null!;
        public DateTimeOffset DataCadastro { get; set; }
        public Contato? Contato { get; set; }

        private ICollection<EnderecoEntrega>? _enderecosEntrega;
        public ICollection<EnderecoEntrega>? EnderecosEntrega {
            get => LazyLoader.Load(this, ref _enderecosEntrega); 
            set => _enderecosEntrega = value; 
        }
        public ICollection<Departamento>? Departamentos { get; set; }
    }
}
