using UnityEngine;

public class Spawn_Info : MonoBehaviour
{
    public GameObject Info;
    public GameObject Info_Spawn;
    public GameObject[] Spawners;
    private int spawnChoice;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnChoice = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Info == null)
        {
            Info = Instantiate(Info_Spawn, Spawners[spawnChoice].transform.localPosition,Quaternion.identity);
            spawnChoice = Random.Range(0, 5);
            for (int i = 0; i < Spawners.Length; i++)
            {
                if (spawnChoice == i)
                {
                    Spawners[i].SetActive(true);
                }
                if (spawnChoice != i)
                {
                    Spawners[i].SetActive(false);
                }
            }
        }

    }
}
