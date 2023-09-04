using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSantoAndre.Model
{
    public class ContaPoupanca : Conta
    //construtor
    {
        //atributo
        private string aniversario;





        public ContaPoupanca(int numero, int agencia, int tipo, string titular, decimal saldo, string aniversario)
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }
        public string getAniversario() { return this.aniversario; }
        public void setAniversario(string aniversario) { this.aniversario = aniversario; }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Aniversário da conta: {aniversario}");
        }

    }

}

