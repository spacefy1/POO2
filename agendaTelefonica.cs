public class agendaTelefonica
{
    private string nome;
    private string numero;

    private string procura;
    Dictionary<string, string> agendaTelefonica2 =
    new Dictionary<string, string>();

    public agendaTelefonica(string nome, string numero)
    {
        this.nome = nome;
        this.numero = numero;
    }

    public void Inserir(string nome, string numero)
    {
        this.agendaTelefonica2.Add(nome, numero);
        Console.WriteLine($"Voce adicionou {nome} e {numero} a agenda telefonica");
    }

    public string BuscarNumero(string procura)
    {
        //preciso fazer direito ainda, mas vou deixar assim por ora
        _ = agendaTelefonica2.TryGetValue(procura, out nome);
        return procura;
    }

    public void Remover(string nome)
    {
        //metodo para remover um nome da agendaTelefonica
        this.agendaTelefonica2.Remove(nome);
        Console.WriteLine($"Voce removeu o {nome} da agenda telefonica");
    }

    public void show()
    {
        if (agendaTelefonica2.Count == 0)
        {
            System.Console.WriteLine("A agenda telefonica está vazia");
        }
        else
        {
            System.Console.WriteLine($"{nome} e {numero} da agenda telefonica");
        }
    }
}