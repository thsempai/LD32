using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class Collision : MonoBehaviour {

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }
    
    public void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.tag == Damage.PLAYER_TAG) {
            other.gameObject.GetComponent<PlatformerCharacter2D>().m_AirControl = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == Damage.PLAYER_TAG) {
            other.gameObject.GetComponent<PlatformerCharacter2D>().m_AirControl = false;
        }
    }

    public void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == Damage.PLAYER_TAG) {
            other.gameObject.GetComponent<PlatformerCharacter2D>().m_AirControl = true;
        }
    }
}