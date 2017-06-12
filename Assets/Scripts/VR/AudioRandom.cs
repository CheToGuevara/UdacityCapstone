using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRandom : MonoBehaviour {

    public AudioClip[] soundFiles;
    public AudioSource soundSource;
    int index=0;
	// Use this for initialization
	void Start () {

        index = Random.Range(0, soundFiles.Length);
        soundSource.clip = soundFiles[index];
        soundSource.Play();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (!soundSource.isPlaying)
        {
            index = (index + 1) % soundFiles.Length;
            soundSource.clip = soundFiles[index];
            soundSource.Play();
        }
		
	}
}
