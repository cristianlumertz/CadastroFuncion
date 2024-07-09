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
    
    switch (menu)
    {
        case 1:
            Console.WriteLine("Digite o nome do funcionário de tempo integral:");
            string nomeint = Console.ReadLine();
            Console.WriteLine("Digite a matrícula:");
            int matriculaint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salário mensal:");
            double salarioMensal = Convert.ToDouble(Console.ReadLine());
            empresa.AdicionarFuncionario(new FuncionarioTempoIntegral(nomeint, matriculaint, salarioMensal));
            break;
        case 2:
            Console.WriteLine("Digite o nome do funcionário de meio período:");
                    string nomemeio = Console.ReadLine();
                    Console.WriteLine("Digite a matrícula:");
                    int matriculameio = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o salário por hora:");
                    double salarioPorHora = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o número de horas trabalhadas:");
                    double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
                    empresa.AdicionarFuncionario(new FuncionarioMeioPeriodo(nomemeio, matriculameio, salarioPorHora, horasTrabalhadas));
                    break;
         case 3:
                    Console.WriteLine("Digite a matrícula do funcionário a ser removido:");
                    int matriculaRemover = Convert.ToInt32(Console.ReadLine());
                    empresa.RemoverFuncionario(matriculaRemover);
                    break;
        case 4:
                    empresa.ExibirFuncionarios();
                    break;
                case 5:
                    Console.WriteLine("Digite a matrícula do funcionário:");
                    int matriculaproj = Convert.ToInt32(Console.ReadLine());
                    var funcionario = empresa.funcionarios.Find(f => f.matricula == matriculaproj);
                    if(funcionario != null)
                    {
                        Console.WriteLine("Digite o nome do projeto ou digite 'sair' para sair.");
                        List<string> projetos = new List<string>();
                        string projeto;

                        do
                        {
                            projeto = Console.ReadLine();
                            if (projeto.ToLower() != "sair");
                            {
                                projetos.Add(projeto);
                            }
                        }while(projeto.ToLower() != "sair");

                        funcionario.AdicionarProjeto(projetos);
                    }
                    else
                    {
                        Console.WriteLine("Funcionario não encontrado");
                    }
                    break;
                case 6:
                    continuar = 0;
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
    }
    }
}

}
