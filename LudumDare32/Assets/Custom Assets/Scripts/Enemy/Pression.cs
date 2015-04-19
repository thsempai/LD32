using UnityEngine;
using System.Collections;

public class Pression : MonoBehaviour {


    public const string PRESSION_TAG = "Pression";
    public bool pressure = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D( Collider2D other) {
        if(other.gameObject.tag == PRESSION_TAG || 
            other.gameObject.tag == Damage.PLAYER_TAG ) {
            pressure = true;
        }
    }

    void OnTriggerExit2D( Collider2D other) {
        if(other.gameObject.tag == PRESSION_TAG || 
            other.gameObject.tag == Damage.PLAYER_TAG ) {
            pressure = false;
        }
    }
}
