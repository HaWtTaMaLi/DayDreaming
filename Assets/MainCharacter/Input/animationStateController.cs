using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    bool isWalking;
    bool isRunning;
    bool isJumping;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool isRunning = animator.GetBool("isRunning");
        bool isJumping = animator.GetBool("isJumping");

        bool forwardPress = Input.GetKey(KeyCode.W);
        bool backwardPress = Input.GetKey(KeyCode.S);
        bool leftPress = Input.GetKey(KeyCode.A);
        bool rightPress = Input.GetKey(KeyCode.R);

        bool runPress = Input.GetKey(KeyCode.RightShift);
        bool jumpPress = Input.GetKey(KeyCode.Space);

        //Walking
        if (!isWalking && forwardPress) //if we are not walking and we press up then walking = true
        {
            Debug.Log("Walking"); //Working
            animator.SetBool("isWalking", true);
        }
        if (isWalking && !forwardPress) //if we are walking and we stop pressing up then walking = false
        {
            Debug.Log("Stopped Walking"); //Working
            animator.SetBool("isWalking", false);
        }

        //Running
        if(!isRunning &&  (runPress && forwardPress)) //if we are not running and we press run && up then running = true
        {
            Debug.Log("Running"); //Not Working
            animator.SetBool("isRunning", true);
        }
        if(isRunning || (!runPress || !forwardPress)) //if we stop pressing run && up then running = false
        {
            Debug.Log("Stopped Running");//Not Working
            animator.SetBool("isRunning", false);
        }

        //Jumping
        if (!isJumping && (jumpPress && forwardPress)) //if we are not jumping and we press jump then jumping = true
        {
            Debug.Log("Jumping"); //Not Working
            animator.SetBool("isJumping", true);
        }
        if (isJumping || (!jumpPress || !forwardPress)) //if we are jumping and we stop pressing jump then jumping = false
        {
            Debug.Log("Stopped Jumping"); //Working but spamming on from start
            animator.SetBool("isJumping", false);
        }
    }
}
