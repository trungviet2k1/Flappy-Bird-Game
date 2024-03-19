using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource pointSound;
    public AudioSource deadSound;
    public AudioClip hasPoint;
    public AudioClip playerDead;
    public AudioClip[] backgroundMusicList;
    private AudioSource audioSource;
    private int currentMusicIndex = 0;

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

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundMusicList[currentMusicIndex];
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.Play();
    }

    public void HasPoint()
    {
        if (pointSound != null)
        {
            pointSound.PlayOneShot(hasPoint);
        }

        if (Manager.instance.Score % 40 == 0 && Manager.instance.Score > 0)
        {
            ChangeBackgroundMusic();
        }
    }

    public void PlayerDead()
    {
        if (deadSound != null)
        {
            deadSound.PlayOneShot(playerDead);
        }
    }

    public void StopBackgroundMusic()
    {
        audioSource.Stop();
    }

    private void ChangeBackgroundMusic()
    {
        currentMusicIndex++;
        if (currentMusicIndex >= backgroundMusicList.Length)
        {
            currentMusicIndex = 0;
        }

        audioSource.clip = backgroundMusicList[currentMusicIndex];
        audioSource.Play();
    }
}