using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExGetData : MonoBehaviour
{
    public Entity_Sheet1 monster;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Entity_Sheet1.Param param in monster.sheets[0].list)
        {
            Debug.Log(param.index + "-" + param.name + "-" + param.hp + "-" + param.mp);
        }
    }

    
}
