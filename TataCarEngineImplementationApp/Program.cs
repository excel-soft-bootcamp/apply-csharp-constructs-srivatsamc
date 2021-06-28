using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarEngineImplementationApp
{
    public class TATACar
    {
        Imotor _performance;

        //Injection through constructor   
        public TATACar(Imotor motor)
        {
            this._performance = motor;
        }
        public void Drive()
        {

            _performance.Start();
        }
        public void Halt()
        {

            _performance.Stop();
        }


    }

    public interface Imotor
    {
        void Start();
        void Stop();

    }

    public class DiCorEngine:Imotor
    {

        public void Start() { }
        public void Stop() { }
    }

    public class VeriCorEngine:Imotor
    {
        public void Start() { }
        public void Stop() { }

    }

    public class MultiJetEngine:Imotor
    {
        public void Start() { }
        public void Stop() { }
    }
    public class RevorTron:Imotor
    {
        public void Start() { }
        public void Stop() { }
    }

    //BS IV 

    //BS VI


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
