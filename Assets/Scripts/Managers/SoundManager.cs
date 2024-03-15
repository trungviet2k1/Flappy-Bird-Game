using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource pointSound;
    public AudioSource deadSound;
    public AudioClip hasPoint;
    public AudioClip playerDead;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void HasPoint()
    {
        if (pointSound != null)
        {
            pointSound.PlayOneShot(hasPoint);
        }
    }

    public void PlayerDead()
    {
        if (deadSound != null)
        {
            deadSound.PlayOneShot(playerDead);
        }
    }
}