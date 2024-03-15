using UnityEngine;

public class ObstacleA : MonoBehaviour
{
    public Vector3 speed;
    
    void Update()
    {
        transform.position += speed * Time.deltaTime;
    }
}