using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HerediaJ_MC_4_FiveToSeven.Services
{
    public class OddOrEvenService
    {
        
    public string OddOrEven(string number)
    {

        bool validation = int.TryParse(number, out int convertedNum);

        if (validation == true)
        {

            if (convertedNum % 2 == 0)
            {
                return $"{number} is Even";
            }
            else
            {
                return $"{number} is Odd";
            }

        }
        else
        {
            return "Numbers only";
        }

    }

    }
}