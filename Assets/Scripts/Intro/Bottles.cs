using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottles : MonoBehaviour {

    public int leveltoLoad = 0;

    GameManager m_gamemanager;
    Vector3 m_initpos;

	// Use this for initialization
	void Start () {

        m_gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        m_initpos = transform.position;
		
	}
	
    public void onPointerEnter()
    {
        InvokeRepeating("RandomizeMovement",0, 0.02f);
    }

    public void onPointerExit()
    {
        CancelInvoke("RandomizeMovement");
        transform.position = m_initpos;
        
    }

    private void RandomizeMovement()
    {
        transform.position= m_initpos+new Vector3(0, Mathf.Sin(Time.time)*0.5f,0);
        transform.Rotate(0, Time.time*0.3f, 0);
    }
    

    public void onPointerClick()
    {
        m_gamemanager.changeLevel(leveltoLoad);
    }
}
