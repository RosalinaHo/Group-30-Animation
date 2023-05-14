using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 1f;
    private bool isMoving = false;

    void Start()
    {
        target = GameObject.Find("Target").GetComponent<Transform>();
    }

    void Update()
{
    if (!isMoving)
    {
        isMoving = true;
        GetComponent<Animator>().SetBool("isIdle", false);
        GetComponent<Animator>().SetBool("isWalking", true);
    }
    transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

    // check if we've reached the target position
    if (transform.position == target.position)
    {
        // stop moving, play idle animation
        isMoving = false;
        GetComponent<Animator>().SetBool("isIdle", true);
        GetComponent<Animator>().SetBool("isWalking", false);
    }
}


}