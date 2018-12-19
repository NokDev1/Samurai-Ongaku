using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour{

	 
	private void OnTriggerEnter(Collider other)
 {
        if(other.gameObject.tag == "play"){
	        SceneManager.LoadScene("game_scene");
	}

	    if(other.gameObject.tag == "menu"){
		    SceneManager.LoadScene("play_scene");
	}

	    if(other.gameObject.tag == "instruct"){
		    SceneManager.LoadScene("instruct_scene");
	}

	    if(other.gameObject.tag == "quit"){
		    Application.Quit();
	}
}
}