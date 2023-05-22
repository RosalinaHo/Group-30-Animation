using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class CharacterController : MonoBehaviour
{
    public Transform[] targets;
    public float moveSpeed = 1f;

    public bool isMoving { get; set; } = false;

    void Start()
    {
        
    }


    void Update()
    {
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