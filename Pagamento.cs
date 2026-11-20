using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Pagamento
    {
        public int NumPagamento { get; set; }
        public int NumAgendamento { get; set; }
        public string FormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        public Pagamento()
        {
            this.FormaPagamento = "";
            this.DataPagamento = DateTime.Now;
        }
    }
}
