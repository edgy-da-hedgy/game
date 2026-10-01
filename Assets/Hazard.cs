using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        balls player = other.GetComponent<balls>();
        if (player != null)
        {
            player.Respawn();
        }
    }
}
