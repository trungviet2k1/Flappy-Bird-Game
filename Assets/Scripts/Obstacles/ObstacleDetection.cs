using UnityEngine;

public class ObstacleDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SoundManager.instance.PlayerDead();
            GameObject.FindWithTag("Manager").GetComponent<Manager>().GameOver();
        }
    }
}
