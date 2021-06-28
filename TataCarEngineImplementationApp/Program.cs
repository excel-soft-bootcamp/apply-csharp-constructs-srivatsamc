using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarEngineImplementationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiJetEngine engine1 = new MultiJetEngine();
            TATACar _harrier = new TATACar(engine1);
            _harrier.Drive();
            _harrier.Halt();

            VeriCorEngine engine2 = new VeriCorEngine(); 
            TATACar _nexon = new TATACar(engine2);
            _nexon.Drive();
            _nexon.Halt();

            RevorTron engine3 = new RevorTron();
            TATACar _hexa = new TATACar(engine3);
            _hexa.Drive();
            _hexa.Halt();

            DiCorEngine engine4 = new DiCorEngine();
            TATACar _indicaVista = new TATACar(engine4);
            _indicaVista.Drive();
            _indicaVista.Halt();
        }

    }
}
