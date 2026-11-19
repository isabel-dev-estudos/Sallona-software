using System;
using System.Collections.Generic;

namespace Agenda
{
    internal class Agendamento
    {
        public int NumAgendamento { get; set; }
        public int NumCliente { get; set; }
        public string Cliente { get; set; }
        public string Procedimentos { get; set; }
        public List<int> NumProcedimentos { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public decimal Valor { get; set; }

        public Agendamento()
        {
            this.Cliente = "";
            this.Procedimentos = "";
            this.NumProcedimentos = new List<int>();
            this.Data = DateTime.Today;
            this.Horario = "";
            this.Valor = 0;
        }
    }
}
