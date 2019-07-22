using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_A
{
    public class SportsCar : Car
    {
        public string GetPetName()
        {
            PetName = "Fred";
            return PetName;
        }
    }
}