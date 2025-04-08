using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PuffyManager : MonoBehaviour
{
    // prefab for spawning puffys
    public GameObject puffyPrefab;

    //setting up slider for puffy size
    public Slider sizeSlider;
    public Vector2 minMaxSize = new Vector2(0.5f, 2f); 

    // event that triggers when a puffy spawns
    public UnityEvent onPuffySpawn;

    // tracks how many puffys have been spawned
    private int score = 0;

    // boundaries for random spawn positions
    public float minX;
    public float maxX;
    public float minY = 1;

    // audio sources for different sounds
    public AudioSource puffyAudioSource;
    public AudioSource pop;

    void Start()
    {
        // add the pop sound to play when puffy spawns
        onPuffySpawn.AddListener(PlayPopSound);

        //slider setup
        sizeSlider.minValue = minMaxSize.x;
        sizeSlider.maxValue = minMaxSize.y;
        sizeSlider.value = 0.5f;
    }

    public void SpawnPuffy()
    {
        // pick random position within boundaries
        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), minY, 0);



        // create new puffy at random position
        GameObject puffy = Instantiate(puffyPrefab, spawnPosition, transform.rotation);

        float size = sizeSlider.value;
        puffy.transform.localScale = new Vector3(size, size, size);

        // get the puffy script to make it float
        Puffy puffyScript = puffy.GetComponent<Puffy>();

        if (puffyScript != null)
        {
            // start floating coroutine
            StartCoroutine(puffyScript.FloatUp());
        }

        // increase score counter
        score++;

        // every 5 puffys play special sound
        if (score == 5)
        {
            puffyAudioSource.Play();
            score = 0; // reset counter
        }

        // trigger all spawn events
        onPuffySpawn.Invoke();
    }

    // plays the pop sound effect
    void PlayPopSound()
    {
        pop.Play();
    }
}