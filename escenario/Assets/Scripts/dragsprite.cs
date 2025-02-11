using UnityEngine;

public class DragSprite : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void OnMouseDown()
    {
        // Cuando se hace clic sobre el sprite, se activa el arrastre
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            // Mueve el sprite según la posición del mouse
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            newPosition.z = 0; // Mantén el sprite en el plano 2D
            transform.position = newPosition;
        }
    }

    void OnMouseUp()
    {
        // Cuando se suelta el clic, se desactiva el arrastre
        isDragging = false;
    }
}