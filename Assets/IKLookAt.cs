using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKLookAt : MonoBehaviour
{
    private Animator anim;
    public GameObject target;
    public float weight = 1f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        layerIndex = 2;
        anim.SetLookAtPosition(target.transform.position);
        anim.SetLookAtWeight(weight);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
