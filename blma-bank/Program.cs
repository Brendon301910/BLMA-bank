using System.Diagnostics.Contracts;
using blma_bank;
using blma_bank.Titular;

Console.WriteLine("Boas vinda ao seu banco, BLMA Bank");


// ContaCorrente conta1 = new ContaCorrente();
// conta1.titular = "Brendon Araujo";
// conta1.conta = "10123-X";
// conta1.numero_agencia = 23;
// conta1.nome_agencia = "Agência central";
// conta1.saldo = 100;

// ContaCorrente conta2 = new ContaCorrente();
// conta2.titular = "Rafael Soares";
// conta2.conta = "111999-X";
// conta2.numero_agencia = 58;
// conta2.nome_agencia = "Agencia central";
// conta2.saldo = 150;



// Console.WriteLine("Saldo do Brendon pré-transferência: " + conta1.saldo);
// Console.WriteLine("Saldo do Rafael pré-transferência: " + conta2.saldo);
// bool transferência = conta1.Transferir(50, conta2);
// Console.WriteLine("Transferência realizada com sucesso? " + transferência);
// Console.WriteLine("Saldo do Rafael pós-transferência: " + conta2.saldo);
// Console.WriteLine("Saldo do Brendon pós-transferência: " + conta1.saldo);

// Cliente cliente = new Cliente();
// cliente.nome = "Brendon Melo";
// cliente.cpf = "123456789";
// cliente.profissao = "Desenvolvedor";

// ContaCorrente conta3 = new ContaCorrente();
// conta3.titular = new Cliente();
// conta3.titular.nome = "Brendon Melo";
// conta3.titular.profissao = "Dev Back-end";
// conta3.titular.cpf = "123456789";
// conta3.conta = "2513252-X";
// conta3.numero_agencia = 35;
// conta3.nome_agencia = "Agencia central";

// Console.WriteLine(conta3.titular.nome);

// if (conta3.titular == null)
// {
//     Console.WriteLine("O campo titular está nulo");
// }
Cliente sarah = new Cliente();
ContaCorrente conta4 = new ContaCorrente(235, "123456-X");
conta4.Saldo = 100;
conta4.Titular = sarah;

Console.WriteLine(conta4.Titular.nome);
Console.WriteLine(conta4.Saldo);
Console.WriteLine(conta4.Numero_agencia);
Console.WriteLine(conta4.Conta);

Console.ReadKey();


