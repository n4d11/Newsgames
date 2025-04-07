using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematica2 : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float speed = 1.0f;

    private void Start()
    {
      transform.position = start.position;  
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, end.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, end.position)< 0.02f)
        {
            SceneManager.LoadScene(6);
        }
    }
}