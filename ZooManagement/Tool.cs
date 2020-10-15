using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    public abstract class Tool:IDangerous
    {
        //Field for Id    
        private int toolID;
        public int ToolID { get { return toolID; } set { toolID = value; } }

        //Property for string Name
        public string Name{get; set;}

        //Property for int Price
        public int Price { get; set; }

        //Property for bool Right Handed Only
        public bool RightHandedOnly { get; set; }

        //Property for bool Left Handed Only
        public bool LeftHandedOnly { get; set; }

        //-Propertyfor int Level 
        public int Level { get; set; }

        //Property for string Description
        public string Description { get; set; }

    }
}
