using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Hurdle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManagement>().GameOver();

            FindObjectOfType<AudioManager>().Play("hurdleCollision");
        }
    }
}
