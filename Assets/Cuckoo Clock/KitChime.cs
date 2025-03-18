using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitChime : MonoBehaviour
{
    public KitClock clock;

    public void Start()
    {
        //clock onTheHour.AddListner(Chime);
    }
    public void Chime(int hour)
    {
        Debug.Log("Chiming !" + hour + " o'clock");
    }
    public void ChimeWithoutArguments()
    {
        Debug.Log("Chiming !");
    }
}
