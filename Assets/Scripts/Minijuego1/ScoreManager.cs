using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;

    private void Update()
    {
        NewLvl();
    }
    private void Awake()
    {
        instance = this;
    }
    public void AddPoint()
    {
        score += 1;

    }
    public void NewLvl()
    {
        if(score == 3)
        {
            SceneManager.LoadScene(4);
        }
    }
}
