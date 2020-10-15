using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooManagement
{
    class ZooManager : IdGenerator
    {
         //Field of list of animals             

        List <Animal> animalList= new List<Animal>();

        //Field of list of tools
        List<Tool> toolsList = new List<Tool>();

        //Field of IdGenerator
        int idGenerators;

        //Property to get tools list (not set, at least not public access)
        public List <Tool> ToolsList { get {   return toolsList;}  protected set { } }

        //Property to get animal list (not set, at least not public access)
        public List<Animal> AnimalList { get { return animalList; } protected set { } }

        //Methods to add animal into these lists and assign a unique id for them (no animal can have the same Id)
        public void AddAnimal(Animal addAnimal)
        {
            IdGenerator idgn = new IdGenerator();  //create IdGenerator object
            int animalID = idgn.GetNewId();        //call GetNewId() method of IdGenerator class using the above created object 
            addAnimal.PersonalID = animalID;       //assign the above ID to the animal that is to be added
            animalList.Add(addAnimal);             //add the the animal to the list. 
        }

        //Methods to add tool into these lists and assign a unique id for them (no tool can have the same Id)
        public void AddTool(Tool addTool)
        {
            IdGenerator idgn = new IdGenerator();  //create IdGenerator object
            int toolID = idgn.GetNewId();         //call GetNewId() method of IdGenerator class using the above created object 
            addTool.ToolID = toolID;             //assign the above ID to the animal that is to be added
            toolsList.Add(addTool);             //add the the animal to the list. 
        
        }

        // Method to FindById for animals
        public Animal FindAnimalByID(int findAnimalByID)
        {
            Animal matchedAnimal=null; 

            foreach(Animal anm in AnimalList)
            {
                if (anm.PersonalID == findAnimalByID)
                {
                    matchedAnimal = anm;
                }
            }
            return matchedAnimal;
        }

        // Method to FindById for tool
        public Tool FindToolByID(int findByToolID)
        {
            Tool matchedTool = null;

            foreach(Tool tool in ToolsList)
            {
                if (tool.ToolID == findByToolID)
                {
                    matchedTool = tool;
                }
            }

            return matchedTool;
        }

        //Method to get all the IDangerous from Animal list
        public List<Animal> dangerousAnimals(int dangerous)
        {
            List<Animal> dangerousAnimalList = new List<Animal>();

            foreach(Animal allDangerousAnimals in AnimalList)
            {
                if(allDangerousAnimals.Level >= dangerous)
                {
                    dangerousAnimalList.Add(allDangerousAnimals);
                }

            }
            return dangerousAnimalList;
        }

        //Method to get all the IDangerous from Tool list
        public List<Tool> dangerousTools(int dangerous)
        {
            List<Tool> dangerousToolsList = new List<Tool>();

            foreach(Tool allDangerousTools in ToolsList)
            {
                if(allDangerousTools.Level>=dangerous)
                {
                    dangerousToolsList.Add(allDangerousTools);
                }
            }

            return dangerousToolsList;
        }

    }
}
