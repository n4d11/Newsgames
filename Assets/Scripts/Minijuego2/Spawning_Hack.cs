using System.Collections;
using UnityEngine;

public class Spawning_Hack : MonoBehaviour
{
    public Transform[] positions;
    private bool Spawning;
    private int RandomSpawn;
    private int RandomAmount;
    public GameObject[] Hacks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Spawning)
        {
            StartCoroutine("Spawner");
        }
    }

    IEnumerator Spawner()
    {
        Spawning = true;
        RandomAmount = Random.Range(2, 6);
        for (int i = 0; i < RandomAmount; i++)
        {
            RandomSpawn = Random.Range(0, 8);
            Instantiate(Hacks[RandomSpawn], new Vector2(positions[RandomSpawn].position.x, positions[RandomSpawn].position.y), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(RandomAmount);
        Spawning=false;
    }
}
