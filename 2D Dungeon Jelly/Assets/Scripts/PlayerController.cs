using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    public int extraJumpsValue;
    private bool facingRight = true;
    private int extraJumps;
    private float horizontalMove;
    private bool isGrounded;
    public float checkRadius;
    private Rigidbody2D rb;
    public Animator animator;
    public Transform groundCheck;
    public ParticleSystem jumpDust;
    public ParticleSystem flipDust;
    public LayerMask whatIsGround;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxisRaw("Horizontal");
        horizontalMove = moveInput * speed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        if (Input.GetButtonDown("Jump") && extraJumps > 0)
        {
            Jump();
            extraJumps--;
        }
        else if (Input.GetButtonDown("Jump") && extraJumps == 0 && isGrounded == true)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);

        if(facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if(facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
        CreateDust(jumpDust);
    }

    void Flip()
    {
        if (isGrounded == true)
        {
            CreateDust(flipDust);
        }
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void CreateDust(ParticleSystem dust)
    {
        dust.Play();
    }
}
