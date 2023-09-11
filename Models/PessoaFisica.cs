namespace Atividade1.Models;

public class PessoaFisica {
    public string Nome { get; set; }
    public string CPF {get; set; }

    public void mostrarDocumento() {
        Console.WriteLine($" Nome: {Nome}\nCPF: {CPF}");
    }
}