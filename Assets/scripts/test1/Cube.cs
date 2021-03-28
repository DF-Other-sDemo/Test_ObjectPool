using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public float upForce = 1;
    public float sideForce = 0.1f;
	// Use this for initialization
	void Start () {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce/2, upForce);
        float zForce = Random.Range(-sideForce, sideForce);
        Vector3 force = new Vector3(xForce, yForce, zForce);
        GetComponent<Rigidbody>().velocity = force;
	}
	
	
}
