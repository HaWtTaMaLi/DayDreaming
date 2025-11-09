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

        bool up = Input.GetKey(KeyCode.W);
        bool down = Input.GetKey(KeyCode.S);
        bool left = Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.R);

        bool run = Input.GetKey(KeyCode.RightShift);
        bool jump = Input.GetKey(KeyCode.Space);

        //Walking
        if (!isWalking && up) //if we are not walking and we press up then walking = true
        {
            Debug.Log("Walking"); //Working
            animator.SetBool("isWalking", true);
        }
        if (isWalking && !up) //if we are walking and we stop pressing up then walking = false
        {
            Debug.Log("Stopped Walking"); //Working
            animator.SetBool("isWalking", false);
        }

        //Running
        if(run && !isRunning && up) //if we are not running and we press run && up then running = true
        {
            Debug.Log("Running"); //Not Working
            animator.SetBool("isRunning", true);
        }
        if(!run && isRunning && up) //if we stop pressing run && up then running = false
        {
            Debug.Log("Stopped Running");//Not Working
            animator.SetBool("isRunning", false);
        }

        //Jumping
        if (jump && !isJumping && up) //if we are not jumping and we press jump then jumping = true
        {
            Debug.Log("Jumping"); //Working (but not playing animation)
            animator.SetBool("isJumping", true);
        }
        if (!jump && isJumping && !up) //if we are jumping and we stop pressing jump then jumping = false
        {
            Debug.Log("Stopped Jumping"); //Not Working
            animator.SetBool("isJumping", false);
        }
    }
}
