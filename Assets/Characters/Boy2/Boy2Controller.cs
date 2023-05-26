using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy2Controller : MonoBehaviour
{
    public IKLookAt lookAt;
    public GameObject[] targets;
    private Animator boy2Anim;
    private float currentTime;
    public float[] times;
    // Start is called before the first frame update
    void Start()
    {
        boy2Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= times[0] && currentTime <= times[0] + 1)
        {
            boy2Anim.SetBool("Wave", true);
        }
        else
        {
            boy2Anim.SetBool("Wave", false);
        }

        if (currentTime >= times[1] && currentTime <= times[1] + 1)
        {
            lookAt.target = targets[0];
            boy2Anim.SetBool("StandUp", true);
            boy2Anim.SetLayerWeight(1, 0);
        }

        if (currentTime >= times[2] && currentTime <= times[2] + 1)
        {
            boy2Anim.SetBool("Walk", true);
        }
    }
}
