using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex.cs
{
    class Calculator
    {
        private int height, weight1;

        public void setHeight(int H)
        {
            this.height = H;
          
        }

            public void setWeight(int W)
        {
            this.weight1 = W;
        }

        public int bodyMass()
        {
            return (weight / height);
        }
    }
}
