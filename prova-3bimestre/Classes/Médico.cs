using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_3bimestre.Classes
{
    internal class Médico:Funcionario
    {
        public string Crm { get; set; }
        public double ValorHoraExtra { get; set; }
        public string Especialidade { get; set; }

        public Médico(string nome, string Cpf, string Matricula, DateTime DataNascimento, string sexo, 
        double Salario, string Crm, double ValorHoraExtra, string Especialidade) 
            : base(nome, Cpf, Matricula, DataNascimento, sexo, Salario)
        {
            this.Crm = Crm;
            this.ValorHoraExtra = ValorHoraExtra;
            this.Especialidade = Especialidade;
        }

        public override string Info()
        {
            return base.Info() + $", CRM: {Crm}, Valor hora extra: {ValorHoraExtra},Especialidade {Especialidade}";
        }


    }
}
