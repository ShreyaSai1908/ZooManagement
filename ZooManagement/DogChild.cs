using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class DogChild:Animal , IDangerous
    {
        //-Propertyforint Level 
        public new int Level { get; set; }

        //Propertyforstring Description
        public new string Description { get; set; }

        public string Vaccinated { get; set; }

        
    }
}
