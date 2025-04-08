using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialEffects : MonoBehaviour
{
    // reference to the puffy manager
    public PuffyManager puffyManager;

    // blood image to show
    public GameObject Image;

    // when enabled, listen for spawn events
    void OnEnable()
    {
        puffyManager.onPuffySpawn.AddListener(ShowBlood);
    }

    // when disabled, stop listening
    void OnDisable()
    {
        puffyManager.onPuffySpawn.RemoveListener(ShowBlood);
    }

    // shows blood effect when called
    void ShowBlood()
    {
        StartCoroutine(img(2f));
    }

    // coroutine that shows image for set time
    IEnumerator img(float duration)
    {
        // turn on image
        Image.SetActive(true);

        // wait for duration
        yield return new WaitForSeconds(duration);

        // turn off image
        Image.SetActive(false);
    }
}