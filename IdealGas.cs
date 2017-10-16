using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldP2_CSharp
{
    class IdealGas
    {
        //--------------------------------------- Private Fields, Setters, & Getters -----------------------------------------//

        //-------------------
        //Mass
        //-------------------
        private double mass;
        public Double GetMass()
        {
            return mass;
        }
        public void SetMass(double mass)
        {
            this.mass = mass;
            Calc();
        }
        //-----------------
        //Volume
        //-----------------
        private double volume;
        public Double GetVolume()
        {
            return volume;
        }
        public void SetVolume(double volume)
        {
            this.volume = volume;
            Calc();
        }
        //--------------------------
        //Temperature
        //--------------------------
        private double temp;
        public Double GetTemp()
        {
            return temp;
        }
        public void SetTemp(double temp)
        {
            this.temp = temp;
            Calc();
        }
        //--------------------------------
        //Molecular Weight
        //--------------------------------
        private double molecularWeight;
        public Double GetMolecularWeight()
        {
            return molecularWeight;
        }
        public void SetMolecularWeight(double molecularWeight)
        {
            this.molecularWeight = molecularWeight;
            Calc();
        }
        //------------------------
        //Pressure
        //------------------------
        private double pressure;
        public Double GetPressure()
        {
            return pressure;
        }


        //----------------------------------------------- Private Methods ---------------------------------------------------//

        private void Calc()
        {
            //Variable Intializations                                                           
            double R = 8.3145;

            //Calculating Mass to Mol Mass
            mass /=  molecularWeight;
            
            //Calculate: pressure in pascals
            pressure = (mass * R * temp) / volume;
        }    
    }
}
