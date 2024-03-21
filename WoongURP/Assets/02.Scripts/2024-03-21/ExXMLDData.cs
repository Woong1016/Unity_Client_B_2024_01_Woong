using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;  // XML사용하기 위해 
using System.IO;

public class ExXMLDData : MonoBehaviour
{
    public string filePath;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/PlaterData.xml";
        Debug.Log(filePath);

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            PlayerData playerdata = new PlayerData();
            playerdata.playerName = "플레이어 1";
            playerdata.playerLevel = 1;
            playerdata.items.Add("돌1");
            playerdata.items.Add("바위1");
            SaveData(playerdata);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            PlayerData playerData = new PlayerData();

            playerData = LoadData();

            Debug.Log(playerData.playerLevel);
            Debug.Log(playerData.playerName);
            Debug.Log(playerData.items[0]);
            Debug.Log(playerData.items[1]);
        }
    }

    void SaveData(PlayerData data)

    {
        XmlSerializer serializer = new XmlSerializer(typeof(PlayerData));
        FileStream steam = new FileStream(filePath, FileMode.Create);
        serializer.Serialize(steam, data);
        steam.Close();
    }
    PlayerData LoadData()
    {
        if(File.Exists(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PlayerData));
            FileStream steam = new FileStream(filePath, FileMode.Open);
            PlayerData data = (PlayerData)serializer.Deserialize(steam);
            return data;
        }
        else
        {
            return null;
        }
    }


}

public class PlayerData
{
    public string playerName;
    public int playerLevel;
    public List<string> items = new List<string>();

}
