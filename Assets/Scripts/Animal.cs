using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private float lowerBound = -10;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
