using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]

    public class ReservaService : IReservaService
    {
        //guarda los datos en memoria del servidor
        // private List<Reserva> listaReserva =new List<Reserva>();

            //conectar con la bd, crear un bd que hereda del modelo
        private bdFinal1Entities bd = new bdFinal1Entities();

        public String ConsultarReserva(int clienteId, DateTime FechaReserva)
        
        {
           
            var res = bd.T_Reservacion.Find(clienteId);
           

            //si la reserva no existe

            if (res == null)
               return String.Format("No existe la Reserva");


            //si la reserva existe
            else
                //deberia salir la fecha de reservacion
              return String.Format("Usted tiene una reservacion para el dia:" +FechaReserva ) ;
            

        }

        public bool ReservarCupo(int clienteId, DateTime fechaReserva, int TelefonoCliente)
        {
            //var res= bd.T_Reservacion.Find( fechaReserva);
            if (fechaReserva == null)
            {
                //si la reserva no existe
                //se crea o agrega una nueva reserva
                //res = new res()                
                bd.T_Reservacion.Add( clienteId,  fechaReserva, TelefonoCliente );
                bd.SaveChanges();
                
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
