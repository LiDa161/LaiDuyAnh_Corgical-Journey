using UnityEngine;

public class StickController : MonoBehaviour
{
    public bool isColliding = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            isColliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            isColliding = false;
        }
    }
}
