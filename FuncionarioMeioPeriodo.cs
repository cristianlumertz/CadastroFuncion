public class FuncionarioMeioPeriodo : Funcionario
{
    private double salariohora;
    private double horastrabalhadas;
    public FuncionarioMeioPeriodo(string nome, int matricula, double salariohora, double horastrabalhadas) : base(nome, matricula)
    {
        this.salariohora = salariohora;
        this.horastrabalhadas = horastrabalhadas;
    }
     public override double CalcularSalario()
    {
        return horastrabalhadas * salariohora;
    
    }
    public override void ExibirInformacao()
    {
        Console.WriteLine("------Informacoes Funcionarios------");
        Console.WriteLine($"      Nome: {nome}");
        Console.WriteLine($"      Numero matricula: {matricula}");
        Console.WriteLine($"      Salario Meio Periodo: {CalcularSalario()}");
    }
    public double CalcularBonus()
    {
        return salariohora * 0.05;
    }
        public override void AdicionarProjeto(string projeto)
    {
        projetos.Add(projeto);
    }
    public override void AdicionarProjeto(List<string> ListaDeProjetos)
    {
        foreach (var projeto in projetos)
        {
            projetos.Add(projeto);
        }
    }
}