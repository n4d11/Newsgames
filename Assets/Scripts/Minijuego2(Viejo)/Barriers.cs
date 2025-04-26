using System.Collections;
using UnityEngine;

public class Barriers : MonoBehaviour
{
    public GameObject[] Barrier;
    private bool BarrierActiveAr;
    private bool BarrierActiveD;
    private bool BarrierActiveAb;
    private bool BarrierActiveI;
    public float BarrierUpTime;

    public GameObject Wave1;
    public GameObject Button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BarrierActiveAr = false;
        BarrierActiveD = false;
        BarrierActiveAb = false;
        BarrierActiveI = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Proteger_Ar()
    {
        if (!BarrierActiveAr)
        {
            StartCoroutine("BarreraAr");
        }
    }
    IEnumerator BarreraAr()
    {
        BarrierActiveAr = true;
        Barrier[0].SetActive(true);
        yield return new WaitForSeconds(BarrierUpTime);
        Barrier[0].SetActive(false);
        BarrierActiveAr = false;
    }


    public void Proteger_D()
    {
        if (!BarrierActiveD)
        {
            StartCoroutine("BarreraD");
        }
    }
    IEnumerator BarreraD()
    {
        BarrierActiveD = true;
        Barrier[1].SetActive(true);
        yield return new WaitForSeconds(BarrierUpTime);
        Barrier[1].SetActive(false);
        BarrierActiveD = false;
    }


    public void Proteger_Ab()
    {
        if (!BarrierActiveAb)
        {
            StartCoroutine("BarreraAb");
        }
    }
    IEnumerator BarreraAb()
    {
        BarrierActiveAb = true;
        Barrier[2].SetActive(true);
        yield return new WaitForSeconds(BarrierUpTime);
        Barrier[2].SetActive(false);
        BarrierActiveAb = false;
    }


    public void Proteger_I()
    {
        if (!BarrierActiveI)
        {
            StartCoroutine("BarreraI");
        }
    }
    IEnumerator BarreraI()
    {
        BarrierActiveI = true;
        Barrier[3].SetActive(true);
        yield return new WaitForSeconds(BarrierUpTime);
        Barrier[3].SetActive(false);
        BarrierActiveI = false;
    }


    public void Starter()
    {
        Wave1.SetActive(true);
        Destroy(Button);
    }
}
