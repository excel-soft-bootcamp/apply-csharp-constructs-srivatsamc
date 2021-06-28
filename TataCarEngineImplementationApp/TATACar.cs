using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarEngineImplementationApp
{
        public class TATACar
        {
            Imotor _motor;

            //Injection through constructor   
            public TATACar(Imotor motor)
            {
                this._motor = motor;
            }
            public void Drive()
            {

                _motor.Start();
            }
            public void Halt()
            {

                _motor.Stop();
            }


        }
    
}
