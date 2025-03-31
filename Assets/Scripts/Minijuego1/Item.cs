using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private SpriteRenderer renderer;
    private bool dragging, placed;
    private Vector2 offset, originalPosition;
    public Slot[] slot;


    public void Init(Slot slot)
    {
        renderer.sprite = slot.Renderer.sprite;
    }
    private void Awake()
    {
        originalPosition = transform.position;
    }
    void Update()
    {
        if (placed) return;
        if (!dragging) return;

        var mousePosition = GetMousePos();
        transform.position = mousePosition - offset;
    }
    void OnMouseDown()
    {
        dragging = true;
        Debug.Log("coger");
        offset = GetMousePos() - (Vector2)transform.position;
    }
    private void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, slot[0].transform.position) < 3)
        {
            if(gameObject.tag == slot[0].gameObject.tag)
            {
                transform.position = slot[0].transform.position;
                ScoreManager.instance.AddPoint();
                slot[0].PLaced();
                placed = true;
                Debug.Log("bien1");
            }
            else
            {
                transform.position = originalPosition;
                dragging = false;
                Debug.Log("mal");
            }
        }
        if (Vector2.Distance(transform.position, slot[1].transform.position) < 3)
        {
            if (gameObject.tag == slot[1].gameObject.tag)
            {
                transform.position = slot[1].transform.position;
                ScoreManager.instance.AddPoint();
                slot[1].PLaced();
                placed = true;
                Debug.Log("bien2");
            }
            else
            {
                transform.position = originalPosition;
                dragging = false;
                Debug.Log("mal");
            }
        }
        if (Vector2.Distance(transform.position, slot[2].transform.position) < 3)
        {
            if (gameObject.tag == slot[2].gameObject.tag)
            {
                transform.position = slot[2].transform.position;
                ScoreManager.instance.AddPoint();
                slot[2].PLaced();
                placed = true;
                Debug.Log("bien3");
            }
            else
            {
                transform.position = originalPosition;
                dragging = false;
                Debug.Log("mal");
            }
        }
         
    }
    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}