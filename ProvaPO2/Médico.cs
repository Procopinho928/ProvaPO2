public class Medico : Funcionario
{
    public string CRM { get; set; }
    public double valorExtra { get; set; }
    public string especialidade { get; set; }

    public Medico(string CRM, double valorExtra, string especialidade, string nome, string cpf, string matricula, DateOnly dataNascimento, string sexo, double salario):base(nome, cpf, matricula, dataNascimento, sexo, salario)
    {
        this.CRM = CRM;
        this.valorExtra = valorExtra;
        this.especialidade = especialidade;
    }

    public override double Acrescimo()
    {
        double porcentagemAcrescimo = (salario * 22) / 100;
        double salarioMedico = porcentagemAcrescimo + salario;
        salario = salarioMedico;
        return salarioMedico;
    }
}