using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public float time = 30f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(time <= 0f){
        Application.LoadLevel("Title");
    }
    else if (Input.GetKeyUp(KeyCode.Escape)) {
                Application.LoadLevel("Title");
            }
    time -= Time.deltaTime;
    }
}
