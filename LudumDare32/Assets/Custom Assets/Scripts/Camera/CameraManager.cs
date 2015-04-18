using UnityEngine;
using System.Collections;



public class CameraManager : MonoBehaviour {


    private TimeManager manager;

    public GameObject cameraPresent;
    public GameObject cameraPast;

    public void SetManager(TimeManager manager) {
        this.manager = manager;
    }

    public void ChangeTime() {
        switch(manager.currentTime) {
            case TimeManager.Time.present : 
                cameraPresent.SetActive(true);
                cameraPast.SetActive(false);
                break;
                
            case TimeManager.Time.past :
                cameraPresent.SetActive(false);
                cameraPast.SetActive(true);
                break;
        }
    }

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }

}
