public class Empresa
{
    List<Funcionario> ListaDeFuncionarios = new List<Funcionario>();
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        ListaDeFuncionarios.Add(funcionario);
    }
    public void RemoverFuncionario(int matricula)
    {
        Funcionario FuncionarioRemover = ListaDeFuncionarios.Find(f => f.matricula == matricula);
        if (FuncionarioRemover != null)
        {
            ListaDeFuncionarios.Remove(FuncionarioRemover);
        } 
        else
        {
            Console.WriteLine($"Funcionario de matricula {matricula} não encontrado.");
        }
    }
    public void ExibirFuncionarios()
    {
        if (ListaDeFuncionarios == null)
        {
            Console.WriteLine("Não há funcionários nessa empresa");
        }
        else
        {
            foreach (Funcionario f in ListaDeFuncionarios)
            {
                Console.WriteLine(f);
            }
        }
    }
}