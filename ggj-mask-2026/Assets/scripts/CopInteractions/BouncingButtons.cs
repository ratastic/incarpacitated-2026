using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BouncingButtons : MonoBehaviour
{
    public float minDistance = 100f;
    private RectTransform rectTransform;
    public Vector2 buttonSpeed;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    void Update()
    {
        //Get mouse position
        Vector2 mousePos; 
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            rectTransform.parent as RectTransform,
            Input.mousePosition,
            null,
            out mousePos
        );

        float currentDistance = Vector2.Distance(rectTransform.anchoredPosition, mousePos);

        //If mouse position is closer that set distance, run away from mouse
        if (currentDistance < minDistance)
        {
            Vector2 direction = (rectTransform.anchoredPosition - mousePos).normalized;
            rectTransform.anchoredPosition += direction * buttonSpeed * Time.deltaTime; //Move
        }

    }
}
