using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trying_search.Models
{
    public class Locking_system
    {
        public string doors { get; set; } 
        public int speed { get; set; } 
        public string act { get; set; }

        public string checkifdoorslock()
        {
            if (speed == 30)
            {
                if(doors=="open")
                {
                    return act = "doors open"; 

                } else
                {
                    return act = "Lock"; 
                }
            } else
            {
                return act = "You driving slowly"; 
            }
        }

    }

}