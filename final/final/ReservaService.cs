﻿using System;
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
       // private readonly DateTime FechaReserva;
        public String ConsultarReserva(int clienteId )
             
           
        {

            var reserva = listaReserva.FirstOrDefault(x=> x.ClienteId == clienteId);
            //si la reserva no existe
            
            if (reserva == null)
               return String.Format("No existe la Reserva");


            //si la reserva existe
            else
              return String.Format("Usted tiene una reservacion para el dia: ") ;
            

        }

        public bool ReservarCupo(int clienteId, DateTime FechaReserva, int TelefonoCliente)
        {
            var reserva = listaReserva.FirstOrDefault(x => x.FechaReserva == FechaReserva);
            if (reserva == null)
            {
                //si la reserva no existe
                //se crea o agrega una nueva reserva
                listaReserva.Add(new Reserva() { ClienteId = clienteId, FechaReserva = FechaReserva,
                    TelefonoCliente = TelefonoCliente });
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
