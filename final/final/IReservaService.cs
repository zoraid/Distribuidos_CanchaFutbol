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
        

        [OperationContract]
        String ConsultarReserva(int clienteId, DateTime FechaReserva);






    }
}
