using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public bool isPlaying = false; 

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume; 
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
        StartCoroutine(IsPlaying());
    }

    IEnumerator IsPlaying()
    {
        isPlaying = true;
        yield return new WaitForSecondsRealtime(0.1f);
        isPlaying = false;
    }
}
