using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private SpriteRenderer renderer;
    private bool dragging, placed;
    private Vector2 offset, originalPosition;
    private Slot slot;

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
        if (Vector2.Distance(transform.position, slot.transform.position) < 3)
        {
            transform.position = slot.transform.position;
            slot.PLaced();
            placed = true;
            Debug.Log("bien");
        }
        else
        {
            transform.position = originalPosition;
            dragging = false;
            Debug.Log("mal");
        }   
    }
    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
