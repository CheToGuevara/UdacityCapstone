using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunWalk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(new Vector3(1, 0, 0), Time.deltaTime*10);
	}
}
