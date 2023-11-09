using PrimeiraApi.Models;
using SistemaDeTarefas.Enums;

namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public int? UsuarioId { get; set; }

        //chave fk de usuario
        public virtual UsuarioModel? Usuario { get; set; }
    }
}
