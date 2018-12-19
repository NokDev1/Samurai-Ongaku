using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiatebb : MonoBehaviour
{
  
    private List<GameObject> bb = new List<GameObject>();
    public float delay;
    private float timer;
    public float nextSpawnTime;
    public float stopTime;
    public float speed;

    void Awake()
    {
        bb.AddRange(GameObject.FindGameObjectsWithTag("bamboo"));
  
    }

    void Start()
    {
        InvokeRepeating("launchBamboo", delay, nextSpawnTime);
    }

    void Update() {
        if (Time.time >= stopTime)
        {
            CancelInvoke("launchBamboo");
        }

    }


    void launchBamboo()
    {
          
          GameObject bbclone = Instantiate(bb[Random.Range(0, bb.Count)]);
          Rigidbody rb = bbclone.GetComponent<Rigidbody>();
          rb.GetComponent<Renderer>().enabled = true;

         timer += Time.deltaTime;
         rb.velocity = transform.forward * Time.deltaTime * speed;

         if (timer >= stopTime) {
            CancelInvoke();
        }
    }


}
