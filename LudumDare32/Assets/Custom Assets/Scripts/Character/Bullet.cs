using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed;

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
}
