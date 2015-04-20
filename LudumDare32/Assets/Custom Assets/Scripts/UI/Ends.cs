using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;


public class Ends : MonoBehaviour {

	// Use this for initialization
    public Animator anim;
    public int choice = 0;
    public Cine trigger;

    public Platformer2DUserControl controler;
    public Rigidbody2D perso;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(trigger.done) {
    if(anim.GetBool("end")) {
        Application.LoadLevel("End");
    }
	}
}

    void OnTriggerEnter2D( Collider2D other) {
        if(trigger.done) {
            
        perso.velocity = new Vector2(perso.velocity.x,0f);
        controler.m_Character.Move(0f,false,false);
        controler.enabled = false;
        anim.SetInteger("choice",choice);
        }
    }

}
