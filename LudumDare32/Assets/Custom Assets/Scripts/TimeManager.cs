using UnityEngine;
using System.Collections;


public class TimeManager : MonoBehaviour {

    public const int PRESENT_LAYER = 9;
    public const int BOTH_LAYER = 8;
    public const int PAST_LAYER = 10;

    public enum Time{
        past, 
        present
    }

    public CameraManager cameraManager;
    public GameObject hero;

    public AudioSource audio_present;
    public AudioSource audio_past;

    public bool free = false;

    public float chrono = 0f;
    

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
        chrono =  Random.Range(2f, 5f);
        if(!free) hero.layer = PRESENT_LAYER;
        currentTime =Time.present;
        audio_past.volume = 0f;
        audio_present.volume = 1f;

    }
    
    // Update is called once per frame
    void Update () {

        if(!free) {
            if (Input.GetKeyUp(KeyCode.B)) {
                GetComponent<AudioSource>().Play();
                if(currentTime == Time.present) {
                    currentTime = Time.past;
                }
                else {
                    currentTime = Time.present;
                }
            }
        }
        else {
            if(chrono <= 0f) {
                chrono =  Random.Range(2f, 5f);
                if(currentTime == Time.present) {
                    currentTime =  Time.past;
                }
                else {
                    currentTime = Time.present;
                }
            }
            chrono -= UnityEngine.Time.deltaTime;
        }
    }

    private void ChangeTime(Time newTime) {
        _currentTime = newTime;

        switch(_currentTime) {
            case Time.present :
                if(!free) hero.layer = PRESENT_LAYER;
                audio_past.volume = 0f;
                audio_present.volume = 1f;
                break;
                
            case Time.past : 
                if(!free) hero.layer = PAST_LAYER;
                audio_past.volume = 1f;
                audio_present.volume = 0f;
                break;
        }

        cameraManager.ChangeTime();
    }
}
