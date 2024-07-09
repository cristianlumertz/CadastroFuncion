public abstract class Funcionario
{
    public string nome;
    public int matricula;
    public List<string> projetos  = new List<string>();
    public Funcionario(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
    }
    public abstract double CalcularSalario();
    public abstract void ExibirInformacao();
    public abstract void AdicionarProjeto(string projeto);
   
    public abstract void AdicionarProjeto(List<string> ListaDeProjetos);
 
    
    

}