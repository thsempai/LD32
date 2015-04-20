using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Life : MonoBehaviour {

    // Use this for initialization
    
    public int life = 3;

    public List<GameObject> hearts;
    public Vector2 damageVelocity = new Vector2();
    public bool dead = false;
    public float time = 0.5f;

    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        for(int index = 0; index < hearts.Count; index ++) {
            hearts[index].SetActive(index < life);
        }
        if(dead) {
            time -= Time.deltaTime;
            if (time <=0f) {
                Application.LoadLevel("GameOver");
            }
        }
    }

    public void Damage(int damage) {
        life -= damage;
        float x = damageVelocity.x;
        if(GetComponent<Rigidbody2D>().velocity.x < 0f) {
            x *= -1f;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f,damageVelocity.y);
        transform.position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z);
        if(life <= 0) {
            Kill();
        }
    }

    public void Kill() {
        life = 0;
        dead = true;
    }
}
