using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterscript : MonoBehaviour
{
    private Rigidbody2D rb; 
    public Animator anim;
    public float moveSpeed = 5f;
    private Vector2 movement;
    private bool speed;
    
    public int maxHealth = 100;
    public int currentHealth;
    
    public HPBar healthBar;

    void Start()
    {
       currentHealth = maxHealth;
       healthBar.SetMaxHealth(maxHealth);
       
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Animate();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        movement = new Vector2(horizontal, vertical).normalized;
    }

    private void Animate()
    {
        if (movement.magnitude > 0.1f)
        {
            speed = true;
        }
        else
        {
            speed = false;
        }
        if(speed)
		{
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
    	}
        anim.SetBool("speed", speed);
    }
    
   
}

