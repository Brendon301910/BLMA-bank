using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blma_bank.Titular;

namespace blma_bank
{
    public class ContaCorrente
    {
        public Cliente titular;
        // public string titular_nome;
        // public string titular_cpf;
        // public string titular_profissao;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor || valor < 0)
            {
                return false;

            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

    }
}