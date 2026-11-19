using System;

namespace Agenda
{
    internal class Agendamento
    {
        public string Cliente { get; set; }
        public string Procedimentos { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public double Valor { get; set; }

        public Agendamento()
        {
            this.Cliente = "";
            this.Procedimentos = "";
            this.Data = DateTime.Today;
            this.Horario = "";
            this.Valor = 0;
        }
    }
}