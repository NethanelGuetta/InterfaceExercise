using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IPerson
    {
        string GetFullName();

        int GetAge();


      
       
    }

    public interface IJob
    { 
        string GetRole();
    }
}
