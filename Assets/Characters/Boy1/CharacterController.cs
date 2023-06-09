using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class CharacterController : MonoBehaviour
{
    public IKLookAt iKLookAt;
    public GameObject[] iKTargets;

    public Transform[] targets;
    public float moveSpeed = 1f;
    private float currentTime;
    public float[] times;

    private Animator boy1Anim;

    public bool isMoving { get; set; } = false;

    void Start()
    {
        boy1Anim = GetComponent<Animator>();
    }


    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= times[0] && currentTime <= times[0] + 1)
        {
            iKLookAt.weight = 1;
            boy1Anim.SetBool("isWalking", true);
        }

        if (currentTime >= times[1] && currentTime <= times[1] + 0.1)
        {
            boy1Anim.SetBool("isWalking", false);
        }

        if (currentTime >= times[2] && currentTime <= times[2] + 1)
        {
            boy1Anim.SetBool("isSitting", true);
            //objTransform.position()
        }

        if (currentTime >= times[3] && currentTime <= times[3] + 1)
        {
            iKLookAt.weight = 0;
            boy1Anim.SetBool("standUp", true);
            //objTransform.position()
        }

        if (currentTime >= 16.1 && currentTime <= 16.6)
        {
            iKTargets[0].transform.position = new Vector3(1.952f, 4, -11);
        }


        /*
        if (!isMoving)
        {
            isMoving = true;
            GetComponent<Animator>().SetBool("isIdle", false);
           // GetComponent<Animator>().SetBool("isWalking", true);
        }
        transform.position = Vector3.MoveTowards(transform.position, targets[0].position, moveSpeed * Time.deltaTime);

        // check if we've reached the target position
        if (transform.position == targets[0].position)
        {
            // stop moving, play idle animation
            isMoving = false;
            GetComponent<Animator>().SetBool("isIdle", true);
            //GetComponent<Animator>().SetBool("isWalking", false);
        }
        
        transform.position = Vector3.MoveTowards(transform.position, targets[0].position, moveSpeed * Time.deltaTime);
        */
    }
}