using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Linq;

public class ExEncrypt : MonoBehaviour
{
    string filePath;
    string key = "ThisIsASecretKey"; // 암호화키
    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + ".EncryptPlayerData.json";
        Debug.Log(filePath);
    }

    byte[] Encrypt(byte[] plainBytes)
    {
        using (Aes aesAlg = Aes.Create()) { }
        {
            aesAlg.key = Encoding.UTF8.GetBytes(key);
            aesAlg.IV = new byte[16];       //IV(intialization Vector) 랜덤값을 사용하거나 고정값을 설정

            //암호화 변환기 생성
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)

            // 스트림 생성
            using (MemoryStream msEncrypt = new MemoryStream())
            {

                //스트림에 암호화 변환기를 연결하여 암호화 스트림을 생성
                using(CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    //암호화 스트림에 데이터 쓰기
                    csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                    csEncrypt.FlushFinalBlock();
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
