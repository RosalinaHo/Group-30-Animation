using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKpuppet : MonoBehaviour
{
    private Animator anim;
    public GameObject target;
    public float IK_weight = 1.0f;

    public GameObject target2;
    public float IK_weight2 = 1.0f;

    public GameObject hint;
    public float IK_hintWeight = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnAnimatorIK(int layerIndex)
    {
        IK_weight = anim.GetFloat("IKWaving");
        anim.SetIKHintPosition(AvatarIKHint.RightElbow, hint.transform.position);
        anim.SetIKHintPositionWeight(AvatarIKHint.RightElbow, IK_hintWeight);

        anim.SetIKPosition(AvatarIKGoal.RightHand, target.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, IK_weight);

        anim.SetIKPosition(AvatarIKGoal.LeftHand, target2.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, IK_weight2);
    }
}
