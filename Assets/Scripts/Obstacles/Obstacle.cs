using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector3 speed;

    void Update()
    {
        transform.position += speed * Time.deltaTime;

        if (transform.position.x < -50f)
        {
            Destroy(gameObject);
        }
    }
}