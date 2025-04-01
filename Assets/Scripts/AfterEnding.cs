using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AfterEnding : MonoBehaviour
{
    public Image MainPanel;
    public Image NewsPaper;
    public Image FadingLetters;
    public TextMeshProUGUI Text;
    public GameObject Button;

    public TextMeshProUGUI Ahorros;
    public float Ahorrado;
    public TextMeshProUGUI PrecioCasa;
    public float CasaP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MainPanel.color = new Color(MainPanel.color.r, MainPanel.color.g, MainPanel.color.b, 0);
        NewsPaper.color = new Color(NewsPaper.color.r, NewsPaper.color.g, NewsPaper.color.b, 0);
        FadingLetters.color = new Color(FadingLetters.color.r, FadingLetters.color.g, FadingLetters.color.b, 1);
        FadingLetters.gameObject.SetActive(false);
        Text.gameObject.SetActive(false);
        Button.SetActive(false);
        Ahorros.gameObject.SetActive(false);
        PrecioCasa.gameObject.SetActive(false);
        StartCoroutine("Fading");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fading()
    {

        while(MainPanel.color.a < 1 && NewsPaper.color.a < 1)
        {
            MainPanel.color = new Color(MainPanel.color.r, MainPanel.color.g, MainPanel.color.b, MainPanel.color.a + (Time.deltaTime / 1));
            NewsPaper.color = new Color(NewsPaper.color.r, NewsPaper.color.g, NewsPaper.color.b, NewsPaper.color.a + (Time.deltaTime / 1));
            yield return null;
        }
        FadingLetters.gameObject.SetActive(true);
        Text.gameObject.SetActive(true);
        Ahorros.gameObject .SetActive(true);
        PrecioCasa.gameObject .SetActive(true);
        while(FadingLetters.color.a >0)
        {
            FadingLetters.color = new Color(FadingLetters.color.r, FadingLetters.color.g, FadingLetters.color.b, FadingLetters.color.a - (Time.deltaTime / 3));
            yield return null;
        }
        Ahorros.text = "Ahorros:" + Ahorrado + "€";
        PrecioCasa.text = "Casa objetivo: " + CasaP + "€";
        Button.SetActive(true );
    }
}
