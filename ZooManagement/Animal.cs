using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    public abstract class Animal : IDangerous
    {
        private int personalID;
        public int PersonalID 
        {
            set 
            {
                personalID = value;
            }
            get 
            {
                return personalID;
            }
        }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        //-Propertyfor int Level 
        public int Level { get; set; }

        //Property for string Description
        public string Description { get; set; }
    }

}
