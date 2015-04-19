using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    public void Quit() {
        Application.Quit();
    }

    public void Load(string name) {
        Application.LoadLevel(name);
    }
}
