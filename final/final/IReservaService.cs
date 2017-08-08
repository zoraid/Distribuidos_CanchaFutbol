using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    [ServiceContract]
    public interface IReservaService
    {

        [OperationContract]
        Boolean ReservarCupo(int clienteId, DateTime FechaReserva, int TelefonoCliente);
        //Boolean ReservarCupo(Reserva res);
        

        [OperationContract]
        String ConsultarReserva(int clienteId, DateTime FechaReserva);
        //String ConsultarReserva(int clienteId);






    }
}
