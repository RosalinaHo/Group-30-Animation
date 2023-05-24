using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy2Controller : MonoBehaviour
{
    public Transform[] targets;
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

        if(currentTime >= times[0])
        {
            boy2Anim.SetBool("Wave", true);
        }
    }
}
