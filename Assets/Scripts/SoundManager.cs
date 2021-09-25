using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager _instance;
    private AudioSource audioSource;
    public AudioClip fSound, lSound, hSound, rSound, ngSound, quSound, congratsSound;
    //public List<AudioClip> allSounds = new List<AudioClip>();

    private void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void fSoundPlay()
    {
        audioSource.PlayOneShot(fSound);
    }

    public void lSoundPlay()
    {
        audioSource.PlayOneShot(lSound);
    }

    public void hSoundPlay()
    {
        audioSource.PlayOneShot(hSound);
    }

    public void rSoundPlay()
    {
        audioSource.PlayOneShot(rSound);
    }

    public void ngSoundPlay()
    {
        audioSource.PlayOneShot(ngSound);
    }

    public void quSoundPlay()
    {
        audioSource.PlayOneShot(quSound);
    }


    public void CongratulationsSoundPlay()
    {
        audioSource.PlayOneShot(congratsSound);
    }
}
