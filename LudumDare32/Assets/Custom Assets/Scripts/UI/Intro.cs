using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(GetComponent<Animator>().GetBool("end")) {
        Application.LoadLevel("1 - Forest");
    }
     if (Input.GetKeyUp(KeyCode.Escape)) {
                Application.LoadLevel("1 - Forest");
            }
	}
}
