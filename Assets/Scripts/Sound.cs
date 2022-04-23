using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


[System.Serializable] //Tells system to display this class in unity



public class Sound //remove monobehaviour reference
{
    public string name;
    public AudioClip clip; //stores audio file

    [Range(0f, 1f)] //set min/max range
    public float volume;

    [Range(0.1f, 3f)]
    public float pitch;

    public bool loop; //check if audio loops

    [HideInInspector]
    public AudioSource source;
}
