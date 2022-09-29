using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Animator anim;
    private float One;
    void Start()
    {
        anim = GetComponent<Animator>();
        One = 1f;
    }

    // player collison detection
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (/*collision == true && */collision.tag == ("Player"))
        {
            anim.SetBool("Attack", true);
            Debug.Log("Oh shit its a player");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("Attack", false);
        Debug.Log("Where'd he go?");
    }

}
