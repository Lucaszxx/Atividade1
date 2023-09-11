namespace Atividade1.Models;

public class NotaFiscal
{
    public PessoaFisica? NotaPessoaFisica { get; set; }
    public PessoaJuridica? NotaPessoaJuridica { get; set; }

    public NotaFiscal(PessoaFisica pessoaFisica, PessoaJuridica? pessoaJuridica) {
        NotaPessoaFisica = pessoaFisica;
        NotaPessoaJuridica = pessoaJuridica;
    }

    public void EmitirNotaPf(PessoaFisica pessoaFisica) {
        NotaPessoaJuridica = null;
        Console.WriteLine($"\nNome pessoa fisica: {pessoaFisica.Nome}");
        Console.WriteLine($"CPF pessoa fisica: {pessoaFisica.CPF}");
        Console.WriteLine("Nota de pessoa fisica emitida com sucesso\n");
    }
    public void EmitirNotaPj(PessoaJuridica pessoaJuridica) {
        NotaPessoaFisica = null;
        Console.WriteLine($"\nNome pessoa juridica: {pessoaJuridica.NomeEmpresa}");
        Console.WriteLine($"CNPJ pessoa juridica: {pessoaJuridica.CNPJ}");
        Console.WriteLine($"Endereço pessoa juridica: {pessoaJuridica.Endereco}");
        Console.WriteLine("Nota de pessoa juridica emitida com sucesso");
    }
}