using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_3bimestre.Classes
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string Nome, string Cpf, string Matricula, DateTime DataNascimento, string Sexo, double Salario)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Matricula = Matricula;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.Salario = Salario;
        }

        public virtual string Info()
        {
            return $"Nome: {Nome}, CPF: {Cpf}, Matrícula {Matricula}, Data de Nascimento: {DataNascimento}, " +
                $"Sexo: {Sexo}, Salário: {Salario}";
        }

    }
}
