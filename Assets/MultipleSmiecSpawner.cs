using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleSmiecSpawner : MonoBehaviour
{
    public List<GameObject> smieci;
    public List<Transform> points;
 

    public void SpawnOne(int spawnCount)
    {
        GameObject smiec =
            Instantiate(smieci[Random.Range(0, smieci.Count)], points[spawnCount]);
        smiec.transform.localPosition = Vector3.zero;
        smiec.transform.SetParent(null);
    }

    public void SpawnWaves(int count)
    {

        for (int i = 0; i < count - 1; i++)
        {
            SpawnOne(i);
        }
    }

    }


