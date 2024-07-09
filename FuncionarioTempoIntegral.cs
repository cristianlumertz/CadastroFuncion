public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    private double salariointegral;
   
    public FuncionarioTempoIntegral(string nome, int matricula, double salariomensal) : base(nome, matricula)
    {
        this.salariointegral = salariomensal;
    }
    public override double CalcularSalario()
    {
        return salariointegral;
    }
    public override void ExibirInformacao()
    {
        Console.WriteLine("------Informacoes Funcionarios------");
        Console.WriteLine($"      Nome: {nome}");
        Console.WriteLine($"      Numero matricula: {matricula}");
        Console.WriteLine($"      Salario Integral: {salariointegral}");
    }
    public double CalcularBonus()
    {
        return salariointegral * 0.1;
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