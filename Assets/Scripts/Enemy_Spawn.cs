using System.Collections;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public Transform[] positions;
    public GameObject Enemy;
    private bool SpawnLimit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnLimit = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnLimit)
        {
            SpawnLimit = false;
            StartCoroutine("SpawnEnemy", 1.5f);
        }
    }
    
    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(Enemy, positions[Random.Range(0,2)]);
        yield return new WaitForSeconds(0.5f);
        Instantiate(Enemy, positions[Random.Range(2, 4)]);
        yield return new WaitForSeconds(0.5f);
        Instantiate(Enemy, positions[Random.Range(4, 6)]);
        yield return new WaitForSeconds(0.5f);
        Instantiate(Enemy, positions[Random.Range(6, 8)]);
        SpawnLimit =true;
    }
}
