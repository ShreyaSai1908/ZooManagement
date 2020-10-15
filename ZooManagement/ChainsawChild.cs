using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class ChainsawChild: Tool, IDangerous
    {
        //Chainsaw child of Tool and implements the IDangerousinterface
       

        public int Level { get; set; }
        public string Description { get; set; }

        //-Property for EngineType 
        public string EngineType { get; set; }

        //Property for Brand
        public string Brand { get; set; }

    }
}
