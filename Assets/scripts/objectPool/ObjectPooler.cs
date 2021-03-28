using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {
    
   [System.Serializable]
    public class Pool
    {
        public string tag;
        
        public GameObject prefab;
        public int size;


    }
    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;
    public static ObjectPooler m_instance;

    void Awake()
    {
        m_instance = this;
    }
	// Use this for initialization
	void Start () {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        Debug.Log(pools.Count);
        foreach(Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for(int i=0;i<pool.size;i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
                Debug.Log(objectPool.Count);
            }
            poolDictionary.Add(pool.tag, objectPool);
        }
	}

    public GameObject SpawnFromPool(string tag,Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("pool with tag" + tag + "is not exist");
            return null;
        }
       
        GameObject objectToSpawn=poolDictionary[tag].Dequeue();
        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;
        IMove imove = objectToSpawn.GetComponent<Cube2>();
        //IMove imove = objectToSpawn.GetComponent<IMove>(); //这两行等价

        Debug.Log(imove); //imove = greenCube 2(clone) (Cube2)
        Debug.Log(imove.GetType());  //Cube2   因为这个物体上的是 Cube2类
        if (imove != null)
            imove.StartMovePosition();
        poolDictionary[tag].Enqueue(objectToSpawn);
        return objectToSpawn;
    }
 
   
	

}
