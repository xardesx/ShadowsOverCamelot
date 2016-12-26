using Shadows_Over_Camelot.Interfaces;
using System;

namespace Shadows_Over_Camelot.Models
{
    class IdentityCard : Card
    {
        String label;

        static card_shirt revers;

        card_shirt avers;

        bool isTraitor { get; set; }

        private string description;

        public IdentityCard(bool x)
        {
            isTraitor = x;
            revers = null; //uuzupełnić

            if (isTraitor)
            {
                label = "Traitor";
                description = " ";//to fill 
                avers = null; //to edit
            }
            else
            {
                label = "Loyal";
                description = " ";//to fill
                avers = null; //uzupełnić
            }
        }

        public string readDescription()
        {
            return description;
        }



    }
}
