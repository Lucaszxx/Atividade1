namespace Atividade1.Models;

public class PessoaJuridica {
    public string NomeEmpresa { get; set; }
    public string CNPJ { get; set; }
    public string Endereco { get; set; }

    public void mostrarDocumentoEmpresa() {
        Console.WriteLine($" Nome Empresa: {NomeEmpresa}\n CNPJ: {CNPJ}\nEndereço: {Endereco}");
    }
}