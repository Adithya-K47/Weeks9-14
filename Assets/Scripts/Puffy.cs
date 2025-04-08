using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puffy : MonoBehaviour
{
    // how fast puffy moves up
    public float speed = 2f;

    // reference to floating coroutine
    private Coroutine floatCoroutine;

    void Start()
    {
        // start floating when created
        floatCoroutine = StartCoroutine(FloatUp());
    }

    // makes puffy float upwards
    public IEnumerator FloatUp()
    {
        // keep moving up until reaching y=8
        while (transform.position.y < 8f)
        {
            // move upward each frame
            transform.position += Vector3.up * speed * Time.deltaTime;
            yield return null;
        }

        // stop when reached top
        StopFloating();
    }

    // stops the floating movement
    void StopFloating()
    {
        if (floatCoroutine != null)
        {
            // stop the coroutine
            StopCoroutine(floatCoroutine);

            // debug message
            Debug.Log("Puffy stopped floating!");
        }
    }
}