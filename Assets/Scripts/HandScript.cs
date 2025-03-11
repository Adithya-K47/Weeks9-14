using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HandScript : MonoBehaviour
{
    public UnityEvent TimerFinshed;
    public float timerlength = 24;
    public float t;
    public float speed = 1f;
    public float currentrot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z + speed * Time.deltaTime);

        t += Time.deltaTime;
        if (t > timerlength)
        {
            t = 0;
            TimerFinshed.Invoke();
        }
        if (t == 1 || t== 2 || t == 3|| t == 4 || t == 5 || t == 6 || t == 7 || t == 8 || t == 9 || t == 10 || t == 11 || t == 12)
        {
            Debug.Log("Hour has passed");
        }
    }
}
