using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarEngineImplementationApp
{
    public class TATACar
    {
        Iperformance _performance;

        //Injection through constructor   
        public TATACar(Iperformance engine)
        {
            this._performance = engine;
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

    public interface Iperformance
    {
        void Start();
        void Stop();

    }

    public class DiCorEngine:Iperformance
    {

        public void Start() { }
        public void Stop() { }
    }

    public class VeriCorEngine:Iperformance
    {
        public void Start() { }
        public void Stop() { }

    }

    public class MultiJetEngine:Iperformance
    {
        public void Start() { }
        public void Stop() { }
    }
    public class RevorTron:Iperformance
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
