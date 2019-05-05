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
        if (GameManager.gm.IsEnd || GameManager.gm.IsPause)
        {
            return;
        }
        int numberPoint = Random.Range(0, points.Count);
        GameObject go = Instantiate(spawnObject[Random.Range(0, spawnObject.Count)], points[numberPoint].transform);
        go.transform.position = points[numberPoint].transform.position;
        if (Random.Range(0, 2) == 1)
        {
            go.gameObject.SendMessage("negativeActivate");
        }
    }
}
