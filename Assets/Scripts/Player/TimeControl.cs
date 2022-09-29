using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    public bool isRewind = false;

    List<Vector3> positions;

    public PlayerController player;

    void Start()
    {
        positions = new List<Vector3>();
    }

    void Update()
    {
        if (player.IsDead())
        {
            StartRewind();
        }
        else
        {
            StopRewind();
        }
    }

    void FixedUpdate()
    {
        if (isRewind)
        {
            Rewind();
        }
        else
        {
            Record();
        }
        if (positions.Count == 0)
        {
            player.SetDead(false);
        }
        if (positions.Count == 600)   //Set to this value so the player goes back exactly 10 seconds after each hit (60 times per second * 10 seconds)
        {
            positions.RemoveAt(599);    //Removes the oldest item in the list
        }
    }

    void Rewind()
    {
        //Debug.Log("Running Rewind()");
        if (positions.Count > 0)
        {
            transform.position = positions[0];
            positions.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }
    }
    void Record()
    {
        //Debug.Log("Calling Record()");
        positions.Insert(0, transform.position);
    }

    public void StartRewind()
    {
        isRewind = true;
    }
    public void StopRewind()
    {
        isRewind = false;
    }
}
