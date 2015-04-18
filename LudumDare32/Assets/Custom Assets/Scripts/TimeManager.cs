using UnityEngine;
using System.Collections;


public class TimeManager : MonoBehaviour {

    public const int PRESENT_LAYER = 9;
    public const int PAST_LAYER = 10;

    public enum Time{
        past, 
        present
    }

    public CameraManager cameraManager;
    public GameObject hero;

    private Time _currentTime = Time.present;

    public Time currentTime{
        get { return _currentTime;

        }
        set {
            ChangeTime(value);
        }
    }
    // Use this for initialization
    void Start () {
        
        cameraManager.SetManager(this);
        hero.layer = PRESENT_LAYER;

    }
    
    // Update is called once per frame
    void Update () {
    if (Input.GetKeyUp(KeyCode.B)) {
        if(currentTime == Time.present) {
            currentTime = Time.past;
        }
        else {
            currentTime = Time.present;
        }
    }
    }

    private void ChangeTime(Time newTime) {
        _currentTime = newTime;

        switch(_currentTime) {
            case Time.present :
                hero.layer = PRESENT_LAYER;
                break;
                
            case Time.past : 
                hero.layer = PAST_LAYER;
                break;
        }

        cameraManager.ChangeTime();
    }
}
