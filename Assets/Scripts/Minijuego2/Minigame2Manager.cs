using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using TMPro;
using UnityEngine.SceneManagement;

public class Minigame2Manager : MonoBehaviour
{
    public static Minigame2Manager instance;
    public int Goal;
    public int currentMoney;
    public int pagoMin;

    public int Timer;
    public int TimeRemain;

    public Canvas StartingCanvas;
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI MoneyText;

    public GameObject PaperGenerators;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PaperGenerators.SetActive(false);
        StartingCanvas.gameObject.SetActive(true);
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if( currentMoney > Goal )
        {
            StopCoroutine("Contador");
            Continuar();
        }
    }

    public void Starting()
    {
        PaperGenerators.SetActive(true);
        TimeRemain = Timer;
        MoneyText.text = "Dinero Reunido: 0/" + Goal;
        StartCoroutine("Contador");
        StartingCanvas.gameObject.SetActive(false);
    }

    IEnumerator Contador()
    {
        while(TimeRemain > 0)
        {
            TimeRemain -= 1;
            TimerText.text = "" + TimeRemain;
            yield return new WaitForSeconds(1);
        }
            SceneManager.LoadScene("Minijuego 2");
    }

    public void Continuar()
    {
        SceneManager.LoadScene(5);
    }
}
