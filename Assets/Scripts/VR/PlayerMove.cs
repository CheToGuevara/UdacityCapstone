using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public GameObject mainobject;

    public AudioClip[] soundFiles;
    public AudioSource soundSource;
    int index = 0;

    public int worldscale = 5;

    Vector3 original_position;

    // Use this for initialization
    void Start () {
        original_position = transform.localPosition;

    }

    // Update is called once per frame
    void Update() {


#if UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {

            Clicked();

        }
#endif

#if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Clicked();
        }
#endif


    }
        void Clicked()
     {
        if (mainobject != null)
        {
            Vector3 m_forw = transform.forward;
            Vector3 m_right = Vector3.Cross(m_forw, new Vector3(0, 1, 0)) * Mathf.Cos(Time.time*2.5f) ;
            Vector3 m_up = new Vector3(0, 1, 0) * Mathf.Cos(Time.time*5);
            mainobject.transform.Translate(new Vector3(m_forw.x,0, m_forw.z)* worldscale * Time.deltaTime);
            transform.localPosition = original_position + (m_right+m_up)*0.025f;
        }

        if (soundSource != null)
        {
            
            if (!soundSource.isPlaying)
            {
                index = (index + 1) % soundFiles.Length;
                soundSource.clip = soundFiles[index];
                soundSource.Play();
            }
        }

    }
}
