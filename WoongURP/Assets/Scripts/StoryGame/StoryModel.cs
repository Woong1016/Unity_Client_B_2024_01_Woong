using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using STORYGAME;

[CreateAssetMenu(fileName ="NewStory", menuName ="ScripttableObjects/StoryModel")]
[System.Serializable]

public class StoryModel : ScriptableObject
{
    public int storyNumber;
    public Texture2D MainImage;
    public bool Done;

    public enum STORYTYPE
    {
        MAIN,
        SUB,
        SERIAL
    }

    public  STORYTYPE storyType;
   
    [TextArea(10, 10)]
    public string StoryText;     // �ν����� text ���� ����
    public Option[] options;     // ������ �迭
    [System.Serializable]
    public class Result
    {
        public enum ResultType : int
        {
            ChangeHp,
            ChangeSp,
            AddExperience,
            GotoShop,
            GotoNextStory,
            GotoRandomStory,
            GotoEnding,

        }
        public ResultType resultType;
        public int value;
        public Stats stats;

    }



    [System.Serializable]
    public class Option
    {
        public string optionText;
        public string buttonText;

        public EventCheck eventcheck;
    }

    [System.Serializable]
    public class EventCheck
    {
        public int checkValue;
        public enum EventType : int 
        {
            NONE,
            GotoBattle,
            CheckSTR,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA
        }
        public Result[] successResult; // �������� ���� ������ �迭
        public Result[] failedResult;   // �������� ���� ���� �� �迭 
    }

}

