using System;
public class Contemplados{
    public int clienteId { get; private set; }
    public string nomeCliente { get; private set; }
    public string primeiroTelefone { get; private set; }
    public string segundoTelefone { get; private set; }
    public string primeiroEmail { get; private set; }
    public string segundoEmail { get; private set; }
    public string endereco { get; private set; }
    public string cidade { get; private set; }
    public string CEP { get; private set; }
    public string observacoesDoCliente { get; private set; }
    public string contemplada { get; private set; } = "1";
    public TipoConsorcio tipoConsorcioInteresse{ get; private set; }
    public double valorConsorcio { get; private set; }
    public FormaContato formaContato { get; private set; }
    public DateTime dataNascimento { get; private set; }
}