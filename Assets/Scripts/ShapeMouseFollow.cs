using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMouseFollow : MonoBehaviour
{
    public SpriteRenderer sr;
    public float c1;
    // Start is called before the first frame update
    void Start()
    {
        sr.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        c1 = Random.Range(0, 255);
        if (Input.GetKeyDown("space"))
        {
            sr.color = Random.ColorHSV();
           
     
        }

        
        
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        transform.position = mouse;
    }
}
