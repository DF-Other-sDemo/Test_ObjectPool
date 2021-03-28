using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject cubePrefab;
	// Update is called once per frame
	void FixedUpdate()
    {
        Instantiate(cubePrefab, transform.position, Quaternion.identity);
    }
}
