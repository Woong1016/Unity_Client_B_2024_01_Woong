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
    string key = "ThisIsASecretKey"; // ��ȣȭŰ
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
            aesAlg.IV = new byte[16];       //IV(intialization Vector) �������� ����ϰų� �������� ����

            //��ȣȭ ��ȯ�� ����
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)

            // ��Ʈ�� ����
            using (MemoryStream msEncrypt = new MemoryStream())
            {

                //��Ʈ���� ��ȣȭ ��ȯ�⸦ �����Ͽ� ��ȣȭ ��Ʈ���� ����
                using(CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    //��ȣȭ ��Ʈ���� ������ ����
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
