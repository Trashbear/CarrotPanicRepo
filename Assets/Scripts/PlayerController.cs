using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rd2d;
    public static int scoreValue = 0;
    float horizontal;
    float vertical;
    public static float speed;

    private float getInput;
    public static float jumpForce;

    private bool onGround;

    public Transform feetPosition;
    public float Radius;

    public LayerMask groundCheck;

    private float jumpCounter;
    public float jumpTime;
    private bool isJumping;

    public GameObject carrotPrefab;

    public GameObject deathBox;
    
    [SerializeField] ParticleSystem carrotGet;

    public GameObject starterText;
    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        getInput = Input.GetAxisRaw("Horizontal");
        rd2d.velocity = new Vector2(getInput * speed, rd2d.velocity.y);
    }

    void Update()
    {
        if(starterText == null && TimerCountdown.secondsLeft > 0)
        {
            Debug.Log("Move");
            speed = 6;
            jumpForce = 9;
        }
        else
        {
            speed = 0;
            jumpForce = 0;
        }

        onGround = Physics2D.OverlapCircle(feetPosition.position, Radius, groundCheck);

        if(onGround == true && Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
            jumpCounter = jumpTime;
            rd2d.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
        
        if(Input.GetKey(KeyCode.W))
        {
           if(jumpCounter > 0 && isJumping == true)
           {
                rd2d.velocity = Vector2.up * jumpForce;
                jumpCounter -= Time.deltaTime;
           }
           else
           {
               isJumping = false;
           }
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            isJumping = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D carrotPrefab)
    {
        scoreValue += 1;
        carrotGet.Play();
        Debug.Log("Score: " + scoreValue);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        DeathBox death = other.gameObject.GetComponent<DeathBox>();

        if (death != null)
        {
            death.deathCheck = true;
        }
    }
}
