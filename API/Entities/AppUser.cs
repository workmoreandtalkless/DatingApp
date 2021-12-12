using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }//we do look at the entity frame work, it's going to recognize that this is going to be our primary key of our database, becuase it's an integer, it's also going to set up our database so it automatically incrementsthe ID field ever time a new record is added to the database .
        public string UserName { get; set; } 
        //public this property can be get offset from any other class in our application and same goes for the class itself.
        //protected , which means this property can be accessed from either this class or any classes that inherit from this class.
        //private access modifier, which means that this property is only accessible from inside this class itself.
    
    }
}