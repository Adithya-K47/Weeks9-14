using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitChime : MonoBehaviour
{
    public KitClock clock;
    AudioSource chime;

    public void Start()
    {
        //clock onTheHour.AddListner(Chime);
    }
    public void Chime(int hour)
    {
        Debug.Log("Chiming !" + hour + " o'clock");
        chime.Play();
    }
    public void ChimeWithoutArguments()
    {
        Debug.Log("Chiming !");
    }
}
