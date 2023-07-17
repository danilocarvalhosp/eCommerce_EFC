using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    [Index(nameof(Email), IsUnique = true, Name = "IX_EMAIL_UNICO")]
    [Index(nameof(Nome), nameof(CPF))]
    [Table("tb_usuarios")]
    public class Usuario
    {
        /*
        [Key]
        [Column("Cod")]
        public int Codigo { get; set; }
        */
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string? Sexo { get; set; }

        [Column("RegistroGeral")]
        public string RG { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        public string? NomePai { get; set; }
        public string SituacaoCadastro { get; set; } = null!;

        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Matricula { get; set; }

        /* RegistroAtivo = (SituaçaoCadastro == "Ativo") ? true : false;
         * Não precisa dele no banco
         */
        [NotMapped]
        public bool RegistroAtivo { get; set; }

        public DateTimeOffset DataCadastro { get; set; }

        [ForeignKey("UsuarioId")]
        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public ICollection<Departamento>? Departamentos { get; set; }

        [InverseProperty("Cliente")]
        public ICollection<Pedido>? PedidosCompradosCliente { get; set; }

        [InverseProperty("Colaborador")]
        public ICollection<Pedido>? PedidosGerenciadoColaborador { get; set; }

        [InverseProperty("Supervisor")]
        public ICollection<Pedido>? PedidosGerenciadoSupervisor { get; set; }
    }
}
