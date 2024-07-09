class Program
{
    public static void Main(string[] args)
{
    Empresa empresa= new Empresa();
    int continuar = 1;

    while (continuar == 1)
    {
        Console.WriteLine("Bem-vindo, selecione uma das opcões: ");
        Console.WriteLine("1. Adicionar funcionário de tempo integral.");
        Console.WriteLine("2. Adicionar funcionário de meio período.");
        Console.WriteLine("3. Remover um funcionário. ");
        Console.WriteLine("4. Exibir informações de todos funcionários.");
        Console.WriteLine("5. Adicionar projeto(s) a um funcionário.");
        Console.WriteLine("6. Sair do programa");
        int menu = Convert.ToInt32(Console.ReadLine());
    }
    switch (menu)
    {
        case 1:
        FuncionarioTempoIntegral f1 = new FuncionarioTempoIntegral();
        f1.nome = Console.ReadLine();
    }
}

}
