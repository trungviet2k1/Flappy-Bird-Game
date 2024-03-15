using UnityEngine;

public class Score : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GameObject.FindWithTag("Manager").GetComponent<Manager>().Score += 1;
        }
    }
}
