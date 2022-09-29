using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCompletion : Interactable
{
    public Task task;
    public override void Interact()
    {
        base.Interact();

        Complete();
    }

    void Complete()
    {
        Debug.Log("Completing task " + task.name);
        task.isComplete = true;
    }
}
