using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class Information
    {
        #region UDT
        private float heightInMeters;
        private float weightInKilos;
        #endregion
#region Initialising UDT
        public float GetheightInMeters()
        {
            return this.heightInMeters;
        }
        public void SetheightInMeters(float heightValue)
        {
            this.heightInMeters = heightValue;
        }

        public float GetweightInKilos()
        {
            return this.weightInKilos;
        }
        public void SetweightInKilos(float weightValue)
        {
            this.weightInKilos = weightValue;

        }
#endregion
    }
}
