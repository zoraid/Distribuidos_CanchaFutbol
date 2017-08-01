using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    [Datacontract]
    public class Reserva
    {
        [DataMember]
        public int ReservaId { get; set; }

        [DataMember]
        public int ClienteId { get; set; }

        [DataMember]
        public DateTime FechaReserva { get; set; }
        
        [DataMember]
        public int TelefonoCliente { get; set; }

    } 
}
