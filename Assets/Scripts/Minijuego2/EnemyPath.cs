using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{
    public Transform[] path;
    private Transform ending;
    private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = Random.Range(0.75f, 1f);
        ending = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine("Pathway");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Pathway()
    {
        for (int i = 0; i < path.Length; i++)
        {
            while(transform.position != path[i].position)
            {
            transform.position = Vector2.MoveTowards(transform.position, path[i].position, speed * Time.deltaTime);
            yield return null;
            }
        }
        while(transform.position != ending.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, ending.position, speed * Time.deltaTime);
            yield return null;
        }
    }
}
