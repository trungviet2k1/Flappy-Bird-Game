using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 birdVelocity;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().velocity = birdVelocity;
        }
    }
}