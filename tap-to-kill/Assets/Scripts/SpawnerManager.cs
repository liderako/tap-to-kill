using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField]private List<GameObject> points;
    [SerializeField]private List<GameObject> spawnObject;

    public void Start() 
    {
        InvokeRepeating("Spawn", 2.0f, 0.3f);
    }

    public void Spawn()
    {
        Instantiate();
    }
}
