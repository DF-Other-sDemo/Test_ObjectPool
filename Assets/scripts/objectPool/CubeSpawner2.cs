using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }
    public GameObject cubePrefab;
    // Update is called once per frame

    public string[] tags = new string[] { "cube", "cube2" };
    void FixedUpdate()
    {

        ObjectPooler.m_instance.SpawnFromPool(tags[Random.Range(0, 1)], transform.position, transform.rotation);
        
        //ObjectPooler.m_instance.SpawnFromPool("cube2", transform.position, transform.rotation);
        //print("hehe");
    }
}
