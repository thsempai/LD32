using UnityEngine;
using System.Collections;


public class Gun : MonoBehaviour {

    const string BULLET_PREFAB = "bullet";

    public float bulletSpeed = 1f;
    public Vector2 delta;
    public bool shooting = false;
    public float timer = 1f;
    private float _timer;



    // Use this for initialization
    void Start () {
    _timer = timer;
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyUp(KeyCode.N)) {
            Shoot();
        }

        if(shooting) {
            _timer -= Time.deltaTime;
        if(_timer <= 0f) {
            Launch();
            _timer = timer;
            shooting = false;
        }
        }
    }

    private void Shoot() {

        if (!shooting) {
            GetComponent<Animator>().SetBool("Shooting",true);
            //GetComponent<AudioSource>().Play();
            shooting = true;
        }

    }

    private void Launch() {

        GameObject bullet =
            Instantiate(Resources.Load(BULLET_PREFAB, typeof(GameObject))) as GameObject;


        float sens = 1f;
        if (transform.localScale.x < 0) {
            sens = -1f;
        }

        float x = transform.position.x + delta.x * sens;
        float y = transform.position.y + delta.y;
        float z = transform.position.z;

        bullet.transform.position = new Vector3(x,y,z);
        bullet.GetComponent<Bullet>().speed = bulletSpeed * sens;
        bullet.layer = gameObject.layer;
    }
}
