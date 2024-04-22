using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCadastro.Models.Pessoa
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }
        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }
        [Required]
        public string EstadoCivil { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string CEP { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Numero { get; set; }
        public string Complemento { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string UF { get; set; }
    }
}
