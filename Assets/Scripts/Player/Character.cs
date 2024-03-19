using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 birdVelocity;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = birdVelocity;
        }
    }
}