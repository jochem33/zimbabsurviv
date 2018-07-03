using UnityEngine;
using System.Collections;

public class Sound_Random : MonoBehaviour
{
    public AudioSource randomSound;
    public AudioClip[] audioSources;
    private int RandomTime;
    public int min = 10;
    public int max = 30;

    void Start()
    {
        CallAudio();
    }

    void CallAudio()
    {
        RandomTime = Random.Range(min, max);
        Invoke("RandomSoundness", RandomTime);
    }

    void RandomSoundness()
    {
        randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
        randomSound.Play();
        CallAudio();
    }
}