using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSantoAndre.Model.Repository
{
    public interface IContaRepository
    {//metodos crud
        public void ProcurarPorNumero(int numero);
        public void ListarTodas();
        public void Cadastrar(Conta conta);
        public void Atualizar(Conta conta);
        public void Deletar(int numero);

        //metodos bancarios
        public void Sacar(Conta conta);
        public void Depositar(int  numero, decimal valor);
        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor);

    }
}
