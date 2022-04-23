using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    void Start()
    {

    }

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)//if there is no audiomanager, use this one
        {
            instance = this;
        }
        else //if there IS an audiomanager, destroy this one
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject); //don't destroy audiomanager when switching scenes

        foreach (Sound s in sounds) //run through every sound and add the properties from 'Sound'
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play(); //if found, play sound
        if (s == null)//can't find sound, print error message
        {
            Debug.LogWarning("sound:" + name + " is not found");
            return;
        }
    }



    void Update()
    {

    }
}