using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToClick : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        mousePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
        }

        if (transform.position != mousePos)
        {
            transform.position = Vector3.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);
        }
    }
}
