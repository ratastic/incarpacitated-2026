using UnityEngine;

public class Arm : MonoBehaviour
{

    Vector3 startPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPoint = transform.parent.position;
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;

        MovingHand();
    }

    public void MovingHand()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);

        newPosition.z = 0;

        transform.position = newPosition;

        Vector3 direction = newPosition - startPoint;
        transform.up = direction;
    }
}
