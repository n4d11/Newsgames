using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinemáticafinal : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
