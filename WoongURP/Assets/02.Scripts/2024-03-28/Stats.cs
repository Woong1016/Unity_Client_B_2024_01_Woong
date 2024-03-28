using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Stats
{
    //체력과 정신력
    public int hpPoint;
    public int spPoint;

    public int currentHpPoint;
    public int currentSpPoint;
    public int currentXpPoint;

    //기본 스탯 설정 (Ex D&D)

    public int strength; // STR 힘
    public int dexterity; // DEX 민첩
    public int consitiution;// CON 건강
    public int Intelligence; //INT 지능
    public int wisdom; //WIS 지혜
    public int charisma;    // CHA 매력
}