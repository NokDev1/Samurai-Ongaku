using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class moveBamboo : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private float timer;
   
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

	void FixedUpdate(){
        timer += Time.deltaTime;
        rb.velocity = transform.right * Time.deltaTime * speed;
       
    }

}
