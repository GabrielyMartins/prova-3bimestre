using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_3bimestre.Classes
{
    internal class Administrativo : Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo(string nome, string Cpf, string Matricula, DateTime DataNascimento, 
            string sexo, double Salario, string funcao) 
            : base(nome, Cpf, Matricula, DataNascimento, sexo, Salario)
        {
            this.Funcao = Funcao;

        }

        public override string Info()
        {
            return base.Info() + $", Função: {Funcao}";
        }

    }
}
