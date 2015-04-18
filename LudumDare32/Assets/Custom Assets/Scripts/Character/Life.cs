using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

    // Use this for initialization
    
    public int life = 3;

    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    public void Damage(int damage) {
        life -= damage;
        if(life <= 0) {
            Kill();
        }
    }

    public void Kill() {
        Destroy(gameObject);
    }
}
