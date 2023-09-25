using prova_3bimestre.Classes;
using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcioanrios = new List<Funcionario>();

        while (true) 
        {
            Console.WriteLine();
            Console.WriteLine("Digite o tipo de funcionário a ser cadastrado " +
                "(médico ou administrativo), ou digite 'sair' para encerrar:");
            string tipoFuncionario = Console.ReadLine();

            if(tipoFuncionario == "sair")
            {
                break;
            }
            
            if(tipoFuncionario == "médico")
            {
                Console.WriteLine("Digite o nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite a matricula");
                string matricula = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento");            
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite o sexo");
                string sexo = Console.ReadLine();
                Console.WriteLine("Digite o salário");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o CRM:");
                string crm = Console.ReadLine();
                Console.WriteLine("Digite o valor da hora extra:");
                double valorHoraExtra = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a especialidade");
                string especialidade = Console.ReadLine();

                Médico medico = new Médico(nome, cpf, matricula, dataNascimento,sexo, 
                    salario, crm, valorHoraExtra, especialidade);
                funcioanrios.Add(medico);
            }

            else if(tipoFuncionario == "administrativo")
            {
                Console.WriteLine("Digite o nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite a matricula");
                string matricula = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento");            
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite o sexo");
                string sexo = Console.ReadLine();
                Console.WriteLine("Digite o salário");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a função");
                string funcao = Console.ReadLine();

                Administrativo administrativo = new Administrativo(nome, cpf, matricula, dataNascimento, sexo,
                    salario, funcao);
                funcioanrios.Add(administrativo);

            }

            else
            {
                Console.WriteLine("Tipo de funcionario inválido. Tente novamente");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Funcionario cadastrados: ");
        foreach (var funcionario in funcioanrios)
        {
            Console.WriteLine(funcionario.Info());
        }
    }
}