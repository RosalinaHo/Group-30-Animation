using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam9Controller : MonoBehaviour
{
    public Animator girl1Anim;
    public Animator girl2Anim;
    public IKLookAt[] lookAt;
    public GameObject[] target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf == true)
        {
            girl1Anim.SetBool("StandUp", true);
            girl2Anim.SetBool("StandUp", true);
            lookAt[0].target = target[0];
            lookAt[1].target = target[1];
        }
    }
}
