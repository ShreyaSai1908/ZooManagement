using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class IdGenerator
    {
        //-Field that is private int idCounter 
        private static int idCounter;
        public int IdCounter { get { return idCounter; } set { }}

        //Method to GetNewId 
        public int GetNewId()
        {
            IdCounter++;
            return IdCounter;
        }

        //Method to LastGivenId
        public int LastGivenId()
        {            
            return IdCounter;
        }
    }
}
