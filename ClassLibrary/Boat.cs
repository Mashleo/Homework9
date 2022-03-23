using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Boat : Transport
    {
        public string surface = "Water";
        public override string ToString()
        {
            return $" Max Speed - {maxSpeed} \t Number Of Pasanger - {numberOfPasanger}\t \n Name Of Company - {nameOfCompany}\t Surface - {surface}\t"; 
        }

    }
}
