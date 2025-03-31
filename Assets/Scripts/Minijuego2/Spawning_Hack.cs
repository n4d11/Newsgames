using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawning_Hack : MonoBehaviour
{
    public Transform[] positions;
    private bool Spawning;
    private int RandomSpawn;
    private int RandomAmount;
    public GameObject[] Hacks;
    private int waveNum = 0;
    public TextMeshProUGUI Show;
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
        if (waveNum >3)
        {
            SceneManager.LoadScene("Minijuego 3");
        }
        Show.text = "Wave: " + waveNum + "/10";
    }

    IEnumerator Spawner()
    {
        waveNum += 1;
        Spawning = true;
        RandomAmount = Random.Range(2,4);
        for (int i = 0; i < RandomAmount; i++)
        {
            RandomSpawn = Random.Range(0, 8);
            Instantiate(Hacks[RandomSpawn], new Vector2(positions[RandomSpawn].position.x, positions[RandomSpawn].position.y), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(RandomAmount + 2);
        Spawning=false;
    }
}
