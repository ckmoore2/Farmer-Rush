using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 15.0f;    
    public float xRange = 20.0f;
    public GameObject projectilePrefab;
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool =GetComponent<ObjectPool>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle forward
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            //Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            pool.Spawn(transform.position);
        }
    }
}
