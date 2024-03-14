using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventpublisher : MonoBehaviour
{
    public EventChannel eventChannel;
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            eventChannel.RaiseEvent();
        }
    }
}
