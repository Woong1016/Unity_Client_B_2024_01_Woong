using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME
{


    public class Enums
    {
        public enum StoryType
        {
            MAIN,
            SUB,
            SERIAL

        }

        public enum EventType
        {
            NONE,
            GoTOBattle = 100,
            CheckSTR = 1000,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA,
        }

        public enum ResultType
        {
            ChangeHp,
            ChangeSp,
            AdoExperience = 100,
            GoRoShop = 1000,
            GoToNextStory = 2000,
            GoToRandomStory = 3000,
            GotoEnding = 10000
        }
    }

} 

