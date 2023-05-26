using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeClock : MonoBehaviour
{
    public Clock clock;
    public GameObject pickedCamera;
    public AudioSource schoolBell;
    private float currentTime;
    public float[] times;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
            if (currentTime >= times[0] && currentTime <= times[0] + 1)
            {
                clock.minutes = 0;
                clock.hour = 0;
                schoolBell.Play();
            }
    }
}
