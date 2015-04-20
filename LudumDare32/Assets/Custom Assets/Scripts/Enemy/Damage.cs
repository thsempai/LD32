using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

    public const string PLAYER_TAG = "Player";

    public bool InstantKill = false;
    public int damage = 1;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    void OnTriggerEnter2D( Collider2D other) {
        if(other.gameObject.tag == PLAYER_TAG) {
            if(InstantKill) {
                other.gameObject.GetComponent<Life>().Kill();
            }
            else {
                GetComponent<AudioSource>().Play();
                other.gameObject.GetComponent<Life>().Damage(damage);
            }
            
        }
    }
}
