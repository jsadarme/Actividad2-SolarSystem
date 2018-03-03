using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Around : MonoBehaviour {
	public Transform SUN;
	public float speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.RotateAround (SUN.position, Vector3.up, speed);
	}
}
