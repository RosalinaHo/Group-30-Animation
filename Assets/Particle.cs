using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public float currentTime;
    public float[] times;
    public GameObject particles;

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
            particles.SetActive(true);
        }
        if (currentTime >= times[1] && currentTime <= times[1] + 1)
        {
            particles.SetActive(false);
        }
    }
}
