using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToTown : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	

    void OnTriggerEnter2d(Collision2D collision)
    {
        if(collision.gameObject.name == "Avatar")
        {
            SceneManager.LoadScene("HomeTown");
        }
    }
}
