using UnityEngine;

public class Arm : MonoBehaviour
{
    public SpriteRenderer armEnd;
    Vector3 startPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPoint = transform.parent.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;

        MovingHand();
    }

    public void MovingHand()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);

        newPosition.z = 0;

        transform.position = newPosition;

        //turns hand and arm direction
        Vector3 direction = newPosition - startPoint;
        transform.up = direction;

        //arm streching and connecting to hand and base
        float dist = Vector2.Distance(startPoint, newPosition);
        armEnd.size = new Vector2(dist, armEnd.size.y);
    }
}
