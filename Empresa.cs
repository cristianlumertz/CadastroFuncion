public class Empresa
{
    public List<Funcionario> funcionarios= new List<Funcionario>();
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }
    public void RemoverFuncionario(int matricula)
    {
        Funcionario FuncionarioRemover = funcionarios.Find(f => f.matricula == matricula);
        if (FuncionarioRemover != null)
        {
            funcionarios.Remove(FuncionarioRemover);
        } 
        else
        {
            Console.WriteLine($"Funcionario de matricula {matricula} não encontrado.");
        }
    }
    public void ExibirFuncionarios()
    {
        if (funcionarios == null)
        {
            Console.WriteLine("Não há funcionários nessa empresa");
        }
        else
        {
            foreach (var funcionario in funcionarios)
            {
                funcionario.ExibirInformacao();
            }
        }
    }
}