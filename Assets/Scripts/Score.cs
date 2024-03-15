using UnityEngine;

public class Score : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GameObject.FindWithTag("Player").GetComponent<Manager>().Score += 1;
        }
    }
}
