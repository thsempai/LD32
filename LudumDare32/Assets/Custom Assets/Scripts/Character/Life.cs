using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Life : MonoBehaviour {

    // Use this for initialization
    
    public int life = 3;

    public List<GameObject> hearts;

    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        for(int index = 0; index < hearts.Count; index ++) {
            hearts[index].SetActive(index < life);
        }
    }

    public void Damage(int damage) {
        life -= damage;
        if(life <= 0) {
            Kill();
        }
    }

    public void Kill() {
        life = 0;
        Destroy(gameObject);
    }
}
