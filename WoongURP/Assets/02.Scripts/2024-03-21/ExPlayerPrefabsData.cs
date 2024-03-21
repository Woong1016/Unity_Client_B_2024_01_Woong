using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExPlayerPrefabsData : MonoBehaviour
{
    public int ScorePoint;
    void SaveData(int Score)
    {
        PlayerPrefs.SetInt("Score", Score);
        PlayerPrefs.Save();
    }

    int LoadData()
    {
        return PlayerPrefs.GetInt("Score");

    }

     void Update()
    {
     if(Input.GetKeyDown(KeyCode.S))
        {
            SaveData(ScorePoint);
        }
     if(Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("score: " + LoadData());
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerPrefs.DeleteKey("Score");
        }
    }
    
}
