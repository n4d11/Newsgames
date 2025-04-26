using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Papel : MonoBehaviour
{
    public GameObject Trabajo;
    private GameObject TrabajoInstance;
    public Transform[] positions;
    private bool papelInactivo;
    public Button AcceptB;
    public Button CancelB;

    public string[] Trabajos;
    private int Precios;
    public int MinPrecio;
    public int MaxPrecio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        papelInactivo = true;
        AcceptB.gameObject.SetActive(false);
        CancelB.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(papelInactivo)
        {
            StartCoroutine("Slide");
        }
    }
    IEnumerator Slide()
    {
        papelInactivo = false;
        yield return new WaitForSeconds(Random.Range(1, 3));
        TrabajoInstance = Instantiate(Trabajo, positions[0].localPosition, Quaternion.identity, this.gameObject.transform);
        TrabajoInstance.transform.Find("Trabajo").GetComponent<TextMeshProUGUI>().text = Trabajos[Random.Range(1, 5)];
        Precios = Random.Range(MinPrecio, MaxPrecio);
        TrabajoInstance.transform.Find("Precio").GetComponent<TextMeshProUGUI>().text = "Precio: " + Precios + "€";
        while (Vector3.Distance(TrabajoInstance.transform.localPosition, positions[1].localPosition) > 1f)
        {
            TrabajoInstance.transform.localPosition = Vector3.MoveTowards(TrabajoInstance.transform.localPosition, positions[1].localPosition, 200 * Time.deltaTime);
            yield return null;
        }
        AcceptB.gameObject.SetActive(true);
        CancelB.gameObject.SetActive(true);
    }

    public void Accept()
    {
        papelInactivo = true;
        AcceptB.gameObject.SetActive(false);
        CancelB.gameObject.SetActive(false);
        Minigame2Manager.instance.currentMoney += Precios - Minigame2Manager.instance.pagoMin;
        Minigame2Manager.instance.MoneyText.text = "Dinero Reunido: " + Minigame2Manager.instance.currentMoney + "/" + Minigame2Manager.instance.Goal;
        Minigame2Manager.instance.TimeRemain -= 10;
        Destroy(TrabajoInstance);
    }

    public void Cancel()
    {
        papelInactivo = true;
        AcceptB.gameObject.SetActive(false);
        CancelB.gameObject.SetActive(false);
        Destroy(TrabajoInstance);
    }
}
