using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Nivel1()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}