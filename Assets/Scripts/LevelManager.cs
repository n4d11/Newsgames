using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject PlayerSpawn;
    public GameObject EnemySpawn;
    public GameObject Button;
    public static LevelManager Instance;
    public TextMeshProUGUI Count;

    private int points = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
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

    public void Goal()
    {
        points++;
        Count.text = points + "/3";
        if (points > 2)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
