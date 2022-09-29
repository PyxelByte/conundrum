using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("the door has opend!");
        anim.SetBool("Door Open", true);
    }

}
