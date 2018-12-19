using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	private static int point;
	public Text scoretext;

	void awake(){
		scoretext = (GameObject.FindWithTag("playerscore")).GetComponent<Text>();	
		point = 0;
		scoretext.text = "Score \n"+point.ToString(); 
 }
	

 private void OnTriggerEnter(Collider other){
	
		if(other.gameObject.tag == "bamboo"){
			point++;
	  }  	
 }

 void Update(){
 
	    scoretext.text = "Score \n"+point.ToString(); 


	}
 

}
