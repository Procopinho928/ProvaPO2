public class Administrativo : Funcionario
{
    public Administrativo(string nome, string cpf, string matricula, DateOnly dataNascimento, string sexo, double salario):base (nome, cpf, matricula, dataNascimento, sexo, salario)
    {

    }

    public override double Acrescimo()//17% sobre os 2000
    {
        double porcentagemAcrescimo = (salario * 17) / 100;
        double salarioAdminstrativo = porcentagemAcrescimo + salario;
        salario = salarioAdminstrativo;
        return salarioAdminstrativo + 250;
    }
}