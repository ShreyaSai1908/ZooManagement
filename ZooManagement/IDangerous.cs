using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    public interface IDangerous
    {
        //-Propertyfor int Level 
        public int Level { get; set; }

        //Property for string Description
        public string Description {get; set;}
    }
}
