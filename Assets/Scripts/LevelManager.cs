using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject PlayerSpawn;
    public GameObject EnemySpawn;
    public GameObject Button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerSpawn.SetActive(false);
        EnemySpawn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        PlayerSpawn.SetActive(true);
        EnemySpawn.SetActive(true);
        Destroy(Button);
    }
}
