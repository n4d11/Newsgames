using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public GameObject canvasfinal;

    private void Update()
    {
        NewLvl();
    }
    private void Awake()
    {
        canvasfinal.gameObject.SetActive(false);
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
            canvasfinal.SetActive(true);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(4);
    }
}
