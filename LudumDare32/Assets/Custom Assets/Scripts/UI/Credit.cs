using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   // Update is called once per frame
    if(GetComponent<Animator>().GetBool("end")) {
        Application.LoadLevel("Title");
    }
}
}

