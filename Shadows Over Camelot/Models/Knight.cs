using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadows_Over_Camelot.Models
{
    public class Knight
    {
        string name { get; set; }
        string description { get; set; }
        string specialPower { get; set; }
        Location location { get; set; }

        Knight(string name, string description, string specialPower)
        {
            this.name = name;
            this.description = description;
            this.specialPower = specialPower;
            location = Location.Camelot;
        }
    }
}
