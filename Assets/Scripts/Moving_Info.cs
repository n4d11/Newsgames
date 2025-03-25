using UnityEngine;
using UnityEngine.InputSystem;

public class Moving_Info : MonoBehaviour
{
    public float speed;
    public float falling;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(speed * Time.deltaTime, falling * Time.deltaTime, 0);
    }

    public void ButtonHeld(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            falling = -falling * 2;
        }
        if (callbackContext.canceled)
        {
            falling = -falling / 2;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
