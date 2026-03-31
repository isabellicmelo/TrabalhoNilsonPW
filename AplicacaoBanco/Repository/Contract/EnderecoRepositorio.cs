using AplicacaoBanco.Models;

namespace AplicacaoBanco.Repository.Contract
{
    public interface IEnderecoRepositorio
    {
        void Cadastrar(Endereco endereco);
        void Atualizar(Endereco endereco);

        void Excluir(int Id);
        Endereco ObterEndereco(int Id);

        IEnumerable<Endereco> ObterTodosEnderecos();
    }
}
