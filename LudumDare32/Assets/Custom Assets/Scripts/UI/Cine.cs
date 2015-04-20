using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityStandardAssets._2D;

public class Cine : MonoBehaviour {

    public bool cine_on = false;
    public bool done = false;

    public List<Text> texts = new List<Text>();
    public List<string> script = new List<string>();
    public int index = -1;

    public float start = 2f;
    public float timer = 4f;
    private float _timer;

    public Platformer2DUserControl controler;
    public Rigidbody2D perso;

    // Use this for initialization
    void Start () {
    _timer = start;
    }
    
    // Update is called once per frame
    void Update () {
        if (cine_on && !done) {
            _timer -= Time.deltaTime;
            if(_timer <= 0f) {
                _timer = timer;
                index++;
                Next();
            }
        }
        if (GetComponent<Animator>().GetBool("go")) {
            controler.enabled = true;
        }
    }

    void OnTriggerEnter2D( Collider2D other) {
        if(!done) {
            
        cine_on =  true;
        perso.velocity = new Vector2(perso.velocity.x,0f);
        controler.m_Character.Move(0f,false,false);
        controler.enabled = false;
        }
    }

    private void Next() {
        if(index < texts.Count) {
            if(index > 0) {

            texts[index-1].text = "";
            }
            texts[index].text = script[index];
        }
        else
        {
            texts[index-1].text = "";
            cine_on = false;
            done = true;
            GetComponent<Animator>().SetBool("go",true);
        }
    }
}
