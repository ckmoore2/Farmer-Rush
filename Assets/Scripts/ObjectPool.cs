using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject objectPrefab;
    public int poolSize;
    private List<GameObject> pool;

    private void Awake()
    {
        if (pool == null)
        {
            //Create the pool
            pool = new List<GameObject>();
        }
        //Loop to create the pool
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
        public GameObject SpawnObject(Vector3 position)
        {
            foreach (GameObject obj in pool);
            {
                if (object.activeSelf == false)
                {
                    //Activate it
                    object.SetActive(true);

                    //Set the position
                    object.transform.position = position;
                    return object;
                }
            }
            //Return null if there are no available objects
            return null;
        }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
