using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventsubscriber : MonoBehaviour
{
    public EventChannel eventChannel;

    private void OnEnable()
    {
        eventChannel.OnEventRaised.AddListener(OnEventRaised);
    }
    private void OnDisable()
    {
        eventChannel.OnEventRaised.RemoveListener(OnEventRaised);
    }


    void OnEventRaised()
    {
        Debug.Log("Event On" + gameObject.name);
    }
}
