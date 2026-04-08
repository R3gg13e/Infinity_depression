using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]float MovementSpeed = 5f;

    Animator animator;
    LevelManager levelManager;

    //Are we jumping
    [SerializeField] bool isJumping;

    private void Awake()

    {
        levelManager = FindAnyObjectByType<LevelManager>();

        animator = GetComponent<Animator>();

        animator.SetBool("IsRunning", true);
        isJumping = false;
    }

    private void Update()
    {
        if (levelManager.CurrentGameState != GameState.Running)
            return;
        {
            // Read in horizontal input (between -1 and 1)
             float horizontalInput = Input.GetAxisRaw("Horizontal");

            //Apply movement
            transform.position += new Vector3(horizontalInput*MovementSpeed * Time.deltaTime, 0f, 0f);

            //Player jump animation
            if (Input.GetKeyDown(KeyCode.Space))
            {
               animator.SetTrigger("Jump");
               isJumping = true;
            }
        }
    }

    public void OnLanding()
    {
        isJumping = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            //stop running
            animator.SetBool("IsRunning", false);

            //let the game manager know that it's game over
            levelManager.DeclareGameOver();
        }

        if (other.gameObject.CompareTag("DamagedRoad") && !isJumping) 
        {
            //stop running
            animator.SetBool("IsRunning", false);

            //let the game manager know that it's game over
            levelManager.DeclareGameOver();
        }
    }



}
