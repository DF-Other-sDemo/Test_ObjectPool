using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour,IMove {

    public float upForce = 1;
    public float sideForce = 0.1f;
    // Use this for initialization
    public void StartMovePosition()
    {
        //print("eee");
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2, upForce);
        float zForce = Random.Range(-sideForce, sideForce);
        Vector3 force = new Vector3(xForce, yForce, zForce);
        GetComponent<Rigidbody>().velocity = force;
    }
    //public void Start()
    //{
    //    print("eee");
    //    float xForce = Random.Range(-sideForce, sideForce);
    //    float yForce = Random.Range(upForce / 2, upForce);
    //    float zForce = Random.Range(-sideForce, sideForce);
    //    Vector3 force = new Vector3(xForce, yForce, zForce);
    //    //GetComponent<Rigidbody>().velocity = force;
    //}

}
