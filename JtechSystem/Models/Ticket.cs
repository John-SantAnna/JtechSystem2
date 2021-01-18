using JtechSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtechSystem.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public DateTime Created { get; set; }
        public DateTime Closed { get; set; }
        public TicketStatus Status { get; set; }
    }
}
