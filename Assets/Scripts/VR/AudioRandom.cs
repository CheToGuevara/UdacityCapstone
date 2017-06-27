using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRandom : MonoBehaviour {

    public AudioClip[] soundFiles;
    public AudioSource soundSource;
    public bool destroyatfinish = false;
    public bool soundatCollision = false;
    int index=0;
	// Use this for initialization
	void Start () {

        if (soundSource != null && !soundatCollision)
        {
            index = Random.Range(0, soundFiles.Length);
            soundSource.clip = soundFiles[index];
            soundSource.Play();
        }
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (soundSource != null && !soundatCollision)
        {
            if (!soundSource.isPlaying)
            {
                index = (index + 1) % soundFiles.Length;
                soundSource.clip = soundFiles[index];
                soundSource.Play();
            }
        }
	}


    private void OnCollisionEnter(Collision collision)
    {
        if (soundSource != null )
        {
            if (!soundSource.isPlaying && collision.transform.CompareTag("Player"))
            {
                Debug.Log("Aqui");
                index = (index + 1) % soundFiles.Length;
                soundSource.clip = soundFiles[index];
                soundSource.Play();
            }
        }

        if (destroyatfinish)
            InvokeRepeating("DestroyThis",0.1f,0.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (soundSource != null)
        {
           
            if (!soundSource.isPlaying && other.transform.CompareTag("Player"))
            {
                
                index = (index + 1) % soundFiles.Length;
                soundSource.clip = soundFiles[index];
                soundSource.Play();
            }
        }

        if (destroyatfinish)
            InvokeRepeating("DestroyThis", 0.1f, 0.1f);
    }


    private void DestroyThis()
    {
        if (soundSource != null)
        {
           
            if (!soundSource.isPlaying)
            {
                Destroy(this.gameObject);
            }
        }
        else
            Destroy(this.gameObject);
    }
}
