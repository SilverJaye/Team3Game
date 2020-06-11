using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerCharacter2D : MonoBehaviour
{
    bool facingRight = true;

    [SerializeField] float maxSpeed = 10f; // The fastest the palyer can travel in the x axis
    [SerializeField] float jumpForce = 400f; // Amount of force added when the player jumps


    [Range(0, 1)]

    [SerializeField] float crouchSpeed = .35f;

    [SerializeField] bool airControl = false;
    [SerializeField] LayerMask whatIsGround;

    Transform groundCheck;
    float groundedRadius = .2f;
    bool grounded = false;
    Transform ceilingCheck;
    float ceilingRadius = .01f;
    Animator anim;

    private void Awake()
    {
        //Setting up References
        groundCheck = transform.Find("GroundCheck");
        ceilingCheck = transform.Find("CeilingCheck");
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        //The palyer is gorunded if a circlecast to the groundcheck position hits anything designed as ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround);
    }










    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
