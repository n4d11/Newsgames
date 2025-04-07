using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void escena()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}