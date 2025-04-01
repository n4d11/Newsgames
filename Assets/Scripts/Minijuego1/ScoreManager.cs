using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public GameObject Ending;

    private void Update()
    {
        NewLvl();
    }
    private void Awake()
    {
        instance = this;
        Ending.SetActive(false);
    }
    public void AddPoint()
    {
        score += 1;

    }
    public void NewLvl()
    {
        if(score == 3)
        {
            Ending.SetActive(true);
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene("Minijuego 2");
    }
}
