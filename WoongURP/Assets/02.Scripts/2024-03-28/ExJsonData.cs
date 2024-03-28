using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using Newtonsoft.Json;      // JSON 직렬화를 위한 패키지
using System.IO;

public class ExJsonData : MonoBehaviour
{

    string filePath;
    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + "/ PlayerData.json";
        Debug.Log(filePath);
    }

    void SaveData(PlayerData data)
    {
        //JSON 직렬화
        string jsonData = JsonConvert.SerializeObject(data);
        //파일저장
        File.WriteAllText(filePath, jsonData);

    }

    PlayerData LoadData()
    {
        if(File.Exists(filePath))
        {
            //파일에서 데이터 읽기
            string jsonData = File.ReadAllText(filePath);

            //Json 역직렬화
            PlayerData data = JsonConvert.DeserializeObject<PlayerData>(jsonData);
            return data;
        }
        else
        {
            return null;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerData playerdata = new PlayerData();
            playerdata.playerName = "플레이어 1";
            playerdata.playerLevel = 1;
            playerdata.items.Add("돌1");
            playerdata.items.Add("바위1");
            SaveData(playerdata);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerData playerData = new PlayerData();

            playerData = LoadData();

            Debug.Log(playerData.playerLevel);
            Debug.Log(playerData.playerName);
           for(int i = 0; i< playerData.items.Count; i++)
            {
                Debug.Log(playerData.items[i]);
            }
        }
    }
}
