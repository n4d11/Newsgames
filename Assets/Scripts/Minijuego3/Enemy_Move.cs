using System.Collections;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("DeSpawn");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
    }
    IEnumerator DeSpawn()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
