using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class KitClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public float timeAnHourTakes = 5;

    public float t;
    public int hour = 0;

    public UnityEvent<int> OnTheHour;

    Coroutine clockIsRunning;
    IEnumerator doOneHour;

    void Start()
    {
        clockIsRunning = StartCoroutine(MoveTheClock());
    }

    private IEnumerator MoveTheClock()
    {
        while (true)
        {
            doOneHour = MoveTheClockHandsMoveOneHour();
            yield return StartCoroutine(doOneHour);
            //yield return StartCoroutine(MoveTheClockHandsMoveOneHour());
        }
    }

    void Update()
    {
        
    }

    private IEnumerator MoveTheClockHandsMoveOneHour()
    {
        while (t < timeAnHourTakes)
        {
            t += Time.deltaTime;
            minuteHand.Rotate(0, 0, -(360 / timeAnHourTakes) * Time.deltaTime);
            minuteHand.Rotate(0, 0, -(30 / timeAnHourTakes) * Time.deltaTime);
            yield return null;
        }
        OnTheHour.Invoke(9);
    }

    public void StopTheClock()
    {
        StopCoroutine(clockIsRunning);
        StopCoroutine(doOneHour);
    }
}
