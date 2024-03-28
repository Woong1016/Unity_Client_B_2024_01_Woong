using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using Newtonsoft.Json;      // JSON ����ȭ�� ���� ��Ű��
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
        //JSON ����ȭ
        string jsonData = JsonConvert.SerializeObject(data);
        //��������
        File.WriteAllText(filePath, jsonData);

    }

    PlayerData LoadData()
    {
        if(File.Exists(filePath))
        {
            //���Ͽ��� ������ �б�
            string jsonData = File.ReadAllText(filePath);

            //Json ������ȭ
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
            playerdata.playerName = "�÷��̾� 1";
            playerdata.playerLevel = 1;
            playerdata.items.Add("��1");
            playerdata.items.Add("����1");
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
