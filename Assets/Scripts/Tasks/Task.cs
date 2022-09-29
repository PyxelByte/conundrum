using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Task", menuName = "Task")]
public class Task : ScriptableObject
{
    new public string name = "New Task";
    public Sprite icon = null;
    public bool isComplete = false;
}
