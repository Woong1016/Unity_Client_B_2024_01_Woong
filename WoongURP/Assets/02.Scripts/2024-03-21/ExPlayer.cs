using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExPlayer : MonoBehaviour
{
    private int health = 100;// 플레이어 체력

    public void TakeDamage(int damage)
    {

        //플레이어 체력감소
        health -= damage;
        Debug.Log("플레이어가 체력: " + health);
        //플레이어가 체력이 0이하로 떨어졌을때 플레이어 사망처리
        if(health<=0)
        {
            Die();
        }

        
    }
    private void Die()
    {

        Debug.Log("플레이어가 사망했습니다");
    }
}
