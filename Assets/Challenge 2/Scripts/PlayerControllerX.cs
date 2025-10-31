using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool readyToSpawn = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (readyToSpawn)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                readyToSpawn = false;
                Invoke("BecomeReady", 0.3f);
            }
        }
    }
    void BecomeReady()
    {
        readyToSpawn = true;
    }
}
