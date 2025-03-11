using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EventsDemo : MonoBehaviour
{
    public RectTransform banana;
    public UnityEvent TimerFinshed;
    public float timerlength = 2;
    public float t;
 
    void Update()
    {
        t += Time.deltaTime;
        if(t > timerlength)
        {
            t = 0;
            TimerFinshed.Invoke();
        }
    }

    

    public void PushedButton()
    {
        Debug.Log("Just pushed a button.");
    }

    public void AlsoPushedButton()
    {
        Debug.Log("pushed another button");
    }
    public void MouseInside()
    {
        Debug.Log("mouse is inside");
        banana.localScale = Vector3.one * 1.2f;
    }
    public void MouseOutside()
    {
        Debug.Log("mouse is outside");
        banana.localScale = Vector3.one;
    }
}
