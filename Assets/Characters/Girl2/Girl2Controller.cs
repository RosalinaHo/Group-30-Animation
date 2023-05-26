using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl2Controller : MonoBehaviour
{
    public Transform[] targets;
    private Animator girl2Anim;
    private float currentTime;
    public float[] times;
    // Start is called before the first frame update
    void Start()
    {
        girl2Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= times[0] && currentTime <= times[0] + 1)
        {
            girl2Anim.SetBool("isLooking", true);
        }

        if (currentTime >= times[1] && currentTime <= times[1] + 1)
        {
            girl2Anim.SetBool("isLooking", true);
        }
    }
}
