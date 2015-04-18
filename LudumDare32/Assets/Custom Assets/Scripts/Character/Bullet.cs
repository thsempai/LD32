using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed;
    public const string ENEMY_TAG = "Enemy";

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        x = x + Time.deltaTime * speed;

        transform.position = new Vector3(x,y,z);
    }

    void OnTriggerEnter2D( Collider2D other) {
        if(other.gameObject.tag != ENEMY_TAG) {
            
            switch (other.gameObject.layer) {
                case TimeManager.BOTH_LAYER :
                    other.gameObject.layer = TimeManager.PRESENT_LAYER; 
                    break;
                case TimeManager.PRESENT_LAYER :
                    other.gameObject.layer = TimeManager.BOTH_LAYER;
                    break;
                default:
                break;
            }
        }

        Destroy(gameObject);
    }

}


