using System;

public class Usuario{

    public int usuarioId { get; private set; }
    public String nome { get; private set; }
    public String email { get; private set; }
    public String login { get; private set; }
    public String senha { get; private set; }
    public EnumeradorPermissao permissao { get; private set; }

}