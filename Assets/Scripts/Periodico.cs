using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Periodico : MonoBehaviour
{
    public TextMeshProUGUI periodicoText;
    public TextMeshProUGUI periodicoTextAhorro;
    public TextMeshProUGUI casaPrecio;
    public Image fondo;
    public Image periodico;
    public Image periodicoCover;
    public Button next;

    private float i;
    private float f;
    public int Ahorro;
    public int precioCasa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        i = 0;
        f = 1;
        fondo.color = new Color (fondo.color.r, fondo.color.g, fondo.color.b, i);
        periodico.color = new Color(periodico.color.r, periodico.color.g, periodico.color.b, i);
        periodicoCover.color = new Color(periodicoCover.color.r, periodicoCover.color.g, periodicoCover.color.b, f);
        periodicoCover.gameObject.SetActive(false);
        periodicoText.gameObject.SetActive (false);
        periodicoTextAhorro.gameObject.SetActive (false);
        casaPrecio.gameObject.SetActive (false);
        next.gameObject.SetActive(false);
        StartCoroutine("Fading");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fading()
    {
        for(i = 0; i < 1; i += Time.deltaTime) 
        {
            fondo.color = new Color(fondo.color.r, fondo.color.g, fondo.color.b, i);
            periodico.color = new Color(periodico.color.r, periodico.color.g, periodico.color.b, i);
            yield return null;
        }
        periodicoCover.gameObject.SetActive(true);
        periodicoText.gameObject.SetActive(true);
        periodicoTextAhorro.gameObject .SetActive(true);
        casaPrecio.gameObject.SetActive(true);
        periodicoTextAhorro.text = "Ahorros:" + Ahorro + "€";
        casaPrecio.text = "Precio casa:" + precioCasa + "€";
        for (f = 1; f > 0; f -= Time.deltaTime)
        {
            periodicoCover.color = new Color(periodicoCover.color.r, periodicoCover.color.g, periodicoCover.color.b, f);
            yield return null;
        }
        next.gameObject.SetActive(true);

    }
}
