using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using System;

public class enemygfx : MonoBehaviour
{
    public AIPath aiPath;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            anim.SetFloat("Speed", 1);
        }
        else if (aiPath.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            anim.SetFloat("Speed", 1);
        }else
        {
            anim.SetFloat("Speed", 0);
        }
    }

}
