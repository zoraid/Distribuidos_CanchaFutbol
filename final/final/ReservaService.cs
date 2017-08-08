using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]

    public class ReservaService : IReservaService
    {

        private List<Reserva> listaReserva =new List<Reserva>();

        //Reserva r = new Reserva();

        public String ConsultarReserva(int clienteId, DateTime FechaReserva)
        //public String ConsultarReserva(int clienteId)
        {
            var reserva = listaReserva.FirstOrDefault(x=> x.ClienteId == clienteId);
            //var fechaReserva = listaReserva.FirstOrDefault(x => x.FechaReserva == FechaReserva);

            //si la reserva no existe

            if (reserva == null)
               return String.Format("No existe la Reserva");


            //si la reserva existe
            else
                //deberia salir la fecha de reservacion
              return String.Format("Usted tiene una reservacion para el dia:" +FechaReserva ) ;
            

        }

        public bool ReservarCupo(int clienteId, DateTime fechaReserva, int TelefonoCliente)
        {
            var reserva = listaReserva.FirstOrDefault(x => x.FechaReserva == fechaReserva);
            if (reserva == null)
            {
                //si la reserva no existe
                //se crea o agrega una nueva reserva
                listaReserva.Add(new Reserva()
                {
                    ClienteId = clienteId,
                    FechaReserva = fechaReserva,
                    TelefonoCliente = TelefonoCliente
                });
                return true;
            }
            else
            {

                //si yaexiste la reservacion
                return false;
            }
        }



    }

        
    
}
