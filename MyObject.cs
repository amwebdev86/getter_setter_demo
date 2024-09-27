using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyObject
    {
        // getter setters allow you to access private data this object holds from another location (object)
        float _health;

        // short hand way of setting Health { get{ return health;}
       
        public float Health
        {
            get
            {
                return _health;
            }
          
            set
            {
                // setting also allows you to add some kind of validations or manipulate the data.

                // make sure health is greater then 10
                if (value <= 4)
                {
                    Console.WriteLine("cannot set health less the 10");
                    return;
                }
                // if health is greater then 10 then set the health
                _health = value;
                Console.WriteLine("you set _health to : " + _health);
            }
        }
    }
}
