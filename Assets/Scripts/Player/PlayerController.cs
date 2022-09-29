using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rig2d;
    public SpriteRenderer sprite;
    public Animator anim;

    public float walkSpeed = 1f;
    public float sprintSpeed = 2f;

    protected float speed;
    public Vector2 movement;

    public bool dead = false;
    public bool atTask = false;

    public Item item;

    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        speed = walkSpeed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = walkSpeed;
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        float animSpeed = Math.Abs(movement.x) + Math.Abs(movement.y);
        anim.SetFloat("speed", animSpeed);

        //sprite flipper
        if (movement.x >= 0.1f)
        {
            sprite.flipX = false;
        }
        else if (movement.x <= -0.1f)
        {
            sprite.flipX = true;
        }
    }

    void FixedUpdate()
    {
        rig2d.MovePosition(rig2d.position + movement * speed/50);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        switch (collision.name)
        {
            case "Gun":
                item = GameObject.Find("Gun").GetComponent<Item>();
                Inventory.instance.Add(item);
                Destroy(item);
                break;
            case "Enemy":
                Debug.Log("Running enemy collision");
                dead = true;
                break;
            case "Engine":
                atTask = true;
                break;
            case "Controls":
                atTask = true;
                break;
            default:
                break;
        }
    }

    public void SetDead(bool dead)
    {
        this.dead = dead;
    }
    public Boolean IsDead()
    {
        return dead;
    }
}
