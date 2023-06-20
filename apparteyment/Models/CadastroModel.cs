using apparteyment.Enums;

namespace apparteyment.Models
{
    public class CadastroModel
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public Perfil Perfil { get; set; }

        public string Senha { get; set; }

        public DateTime DatadeCadastro { get; set; }

        public DateTime? DatadeAtualizacao { get; set; }
    }
}
