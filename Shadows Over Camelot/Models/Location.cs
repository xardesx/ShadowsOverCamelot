using Shadows_Over_Camelot.Interfaces;

namespace Shadows_Over_Camelot.Models
{
    interface Location
    {
        bool HeroicAction(GoodCard card);
        bool WinMission();
        bool LoseMission();
    }
}