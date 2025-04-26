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
    public GameObject next;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        next.SetActive(false);
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
            player.SetActive(false);
            Spawning=true;
            StopCoroutine("Spawner");
            next.SetActive(true);
        }
        Show.text = "Wave: " + waveNum + "/3";
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

    public void NextLevel()
    {
        SceneManager.LoadScene(7);
    }
}
