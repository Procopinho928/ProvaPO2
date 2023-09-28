using System;

class ProvaPO2
{
  
    public static List<Funcionario> listaFuncionarios = new List<Funcionario>();
    public static List<Medico> listaMedico = new List<Medico>();
    public static List<Administrativo> listaAdministrativo = new List<Administrativo>();
    static void Main(string[] args)
    {
        try
        {
            
            while (true)
            {
            voltar:
                Console.Clear();
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite seu cpf: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Digite sua matricula: ");
                string matricula = Console.ReadLine();

                Console.WriteLine("Digite sua data de nascimento: ");
                DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu sexo: ");
                string sexo = Console.ReadLine();

                Console.WriteLine("Digite seu salario: ");
                double salario = Convert.ToDouble(Console.ReadLine());

                Console.Clear();
            voltar3:
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1- Funcionario Comum");
                Console.WriteLine("2- Médico");
                Console.WriteLine("3- Funcionario Administrativo");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Funcionario conexao = new Funcionario(nome, cpf, matricula, dataNascimento, sexo, salario);
                        listaFuncionarios.Add(conexao);
                        Console.WriteLine("Salvo com sucesso!");
                        Console.Clear();
                        Console.WriteLine("Seu salario: " + conexao.Acrescimo());
                        break;

                    case 2:
                        Console.WriteLine("Digite seu CRM: ");
                        string CRM = Console.ReadLine();
                        Console.WriteLine("Digite o valor de hora extra: ");
                        double valorExtra = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite sua especialidade: ");
                        string especialidade = Console.ReadLine();
                        Medico conexao1 = new Medico(CRM, valorExtra, especialidade, nome, cpf, matricula, dataNascimento, sexo, salario);
                        listaMedico.Add(conexao1);
                        Console.WriteLine("Salvo com sucesso!");
                        Console.WriteLine("Seu salario: " + conexao1.Acrescimo());
                        break;

                    case 3:
                        Administrativo conexao2 = new Administrativo(nome, cpf, matricula, dataNascimento, sexo, salario);
                        Console.Clear();
                        Console.WriteLine("Seu salario: " + conexao2.Acrescimo());
                        break;

                    default:
                        Console.WriteLine("Opção Invalida!");
                        goto voltar3;
                        break;
                }
            voltar2:
                Console.WriteLine("Voce deseja parar?");
                Console.WriteLine("0- Sim");
                Console.WriteLine("1- Não");
                Console.WriteLine("2- Ver os funcionarios com salario acima de 2000: ");
                Console.WriteLine("3- Ver todos os funcionarios: ");
                int opcao2 = Convert.ToInt32(Console.ReadLine());

                if (opcao2 == 0)
                {
                    Console.WriteLine("Fechando Programa!");
                    break;
                }
                else if (opcao2 == 1)
                {
                    goto voltar;
                }
                else if (opcao2 == 2)
                {
                    Console.Clear();
                    ExibirFuncionariosSalario();
                    goto voltar2;
                }
                else if (opcao2 == 3)
                {
                    Console.Clear();
                    ExibirFuncionario();
                    goto voltar2;
                }
                else
                {
                    Console.WriteLine("Opcao Invalida!");
                    goto voltar2;
                }


            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void ExibirFuncionariosSalario()
    {
        bool existencia = false;
        foreach (Funcionario str in listaFuncionarios)
        {
            if (str.salario > 2000)
            {
                existencia = true;
                Console.WriteLine("Funcionario Comum: " + str.nome + " possui o salario " + str.salario);
            }
        }

        foreach (Medico str in listaMedico)
        {
            if (str.salario > 2000)
            {
                existencia = true;
                Console.WriteLine("Médico: " + str.nome + " possui o salario " + str.salario);
            }
        }

        foreach (Administrativo str in listaAdministrativo)
        {
            if (str.salario > 2000)
            {
                existencia = true;
                Console.WriteLine("Funcionario Administrativo: " + str.nome + " possui o salario " + str.salario);
            }
        }

        if (existencia == false)
        {
            Console.WriteLine("Ainda nao ha funcionarios com salario maior que 2000!");
        }
    }

    public static void ExibirFuncionario()
    {
        foreach (Funcionario str in listaFuncionarios)
        {
            Console.WriteLine("Funcionarios Comuns: ");
            Console.WriteLine("Nome: " + str.nome);
            Console.WriteLine("CPF: " + str.cpf);
            Console.WriteLine("Matricula: " + str.matricula);
            Console.WriteLine("Data Nascimento: " + str.dataNascimento);
            Console.WriteLine("Sexo: " + str.sexo);
            Console.WriteLine("Salario: " + str.salario);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }

        foreach (Medico str in listaMedico)
        {
            Console.WriteLine("Funcionarios Médicos: ");
            Console.WriteLine("Nome: " + str.nome);
            Console.WriteLine("CPF: " + str.cpf);
            Console.WriteLine("Matricula: " + str.matricula);
            Console.WriteLine("Data Nascimento: " + str.dataNascimento);
            Console.WriteLine("Sexo: " + str.sexo);
            Console.WriteLine("Salario: " + str.salario);

            Console.WriteLine("\nCRM: " + str.CRM);
            Console.WriteLine("Valor Extra: " + str.valorExtra);
            Console.WriteLine("Especialidade: " + str.especialidade);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }

        foreach (Administrativo str in listaAdministrativo)
        {
            Console.WriteLine("Funcionarios Adminstrativo: ");
            Console.WriteLine("Nome: " + str.nome);
            Console.WriteLine("CPF: " + str.cpf);
            Console.WriteLine("Matricula: " + str.matricula);
            Console.WriteLine("Data Nascimento: " + str.dataNascimento);
            Console.WriteLine("Sexo: " + str.sexo);
            Console.WriteLine("Salario: " + str.salario);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }
    }
}