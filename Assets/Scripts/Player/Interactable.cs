using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour
{

    public float radius;
    public Transform interactionTransform;
    public Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        float distance = Vector3.Distance(player.position, interactionTransform.position);
        if (distance <= radius && Input.GetKey(KeyCode.E)) {
                Interact();
        }
    }

    public virtual void Interact()
    {
        //Overwritten by child objects
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

}