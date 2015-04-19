using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    // Use this for initialization

    public float speed = 1f;
    public Vector2 displacement;

    public Vector2 limitInf;
    public Vector2 limitSup;
    public Vector2 sens;

    void Start () {
        if (displacement.x > 0f) {
            sens.x = 1f;
            limitInf.x = transform.position.x;
            limitSup.x = transform.position.x + displacement.x;
        }
        else if (displacement.x < 0f) {
            sens.x = -1f;
            limitInf.x = transform.position.x - displacement.x;
            limitSup.x = transform.position.x;
        }
        else {
            sens.x = 0f;
            limitInf.x = transform.position.x;
            limitSup.x = transform.position.x;
        }

        if (displacement.y > 0f) {
            sens.x = 1f;
            limitInf.y = transform.position.y;
            limitSup.y = transform.position.y + displacement.y;
        }
        else if (displacement.y < 0f) {
            sens.y = -1f;
            limitInf.y = transform.position.y - displacement.y;
            limitSup.y = transform.position.y;
        }
        else {
            sens.y = 0f;
            limitInf.y = transform.position.y;
            limitSup.y = transform.position.y;
        }

    }
    
    // Update is called once per frame
    void Update () {

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        x += sens.x *speed * Time.deltaTime;
        y += sens.y *speed * Time.deltaTime;

        transform.position = new Vector3(x,y,z);
        transform.localScale = new Vector3(sens.x, 1f, 1f);

        if(x < limitInf.x && sens.x < 0f || x > limitSup.x && sens.x > 0f) {
            sens.x *= -1f;
        }
    
        if(y < limitInf.y && sens.y < 0f || y > limitSup.y && sens.y > 0f) {
            sens.y *= -1f;
        }

    }
}
