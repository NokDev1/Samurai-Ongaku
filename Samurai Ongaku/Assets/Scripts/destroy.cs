using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
      
public GameObject parWood;

 private void OnTriggerEnter (Collider other)
 
 {
	Destroy (other.gameObject);
    GameObject woodEffect = Instantiate(parWood, other.transform.position, other.transform.rotation);
 }

}
