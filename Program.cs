// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using Atividade1.Models;

List<NotaFiscal> notasFiscais = new List<NotaFiscal>();
var pessoaJuridica = new PessoaJuridica();
var pessoaFisica = new PessoaFisica();
var funcaoSelecionada = 0;
do
{
    Console.WriteLine("EMISSOR DE NOTA FISCAL");
    Console.WriteLine("1 - Criar Pessoa Fisica");
    Console.WriteLine("2 - Criar Pessoa Juridica");
    Console.WriteLine("3 - Emitir Nota Pessoa Fisica");
    Console.WriteLine("4 - Emitir Nota Pessoa Juridica");
    funcaoSelecionada = int.Parse(Console.ReadLine());

    if (funcaoSelecionada == 1)
    {
        Console.WriteLine("Criar Pessoa Fisica");
        Console.WriteLine("Nome:");
        pessoaFisica.Nome = Console.ReadLine();
        Console.WriteLine("CPF:");
        pessoaFisica.CPF = Console.ReadLine();
    }
    else if (funcaoSelecionada == 2)
    {
        Console.WriteLine("Criar pessoa Juridica");
        Console.WriteLine("Nome:");
        pessoaJuridica.NomeEmpresa = Console.ReadLine();
        Console.WriteLine("Digite o CNPJ:");
        pessoaJuridica.CNPJ = Console.ReadLine();
    }
    else if (funcaoSelecionada == 3)
    {
        if (pessoaFisica.Nome == null || pessoaFisica.CPF == null)
        {
            Console.WriteLine("Pessoa fisica não existe");
        }
        else
        {
            Console.WriteLine("Emitir Nota Pessoa Fisica");
            var notaFiscal = new NotaFiscal(pessoaFisica, pessoaJuridica);
            notaFiscal.EmitirNotaPf(pessoaFisica);
        }
    }
    else if (funcaoSelecionada == 4)
    {
        if (pessoaJuridica.NomeEmpresa == null || pessoaJuridica.CNPJ == null || pessoaJuridica.Endereco == null)
        {
            Console.WriteLine("Pessoa juridica não existe");
        }
        else
        {
            Console.WriteLine("Emitir Nota Pessoa Juridica");
            var notaFiscal = new NotaFiscal(pessoaFisica, pessoaJuridica);
            notaFiscal.EmitirNotaPj(pessoaJuridica);
        }
    }
    else
    {
        Console.WriteLine("Opção não existe!");
    }
} while (funcaoSelecionada != 1 || funcaoSelecionada != 2 || funcaoSelecionada != 3 || funcaoSelecionada == 4);