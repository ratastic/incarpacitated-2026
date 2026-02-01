using UnityEngine;

public class HoverFlaps : MonoBehaviour
{
    public Sprite normalS;
    public Sprite normalS2;

    public Sprite clickS;

        private SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = normalS;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 world = Camera.main.ScreenToWorldPoint(mouse);

        world.z = 0f;
        transform.position = world;

        if (Input.GetMouseButtonDown(0))
        {
            sr.sprite = clickS;


        }

        RaycastHit2D hit = Physics2D.Raycast(world, Vector2.zero);

        if (!Input.GetMouseButton(0)) 
        {
            if (hit.collider != null && hit.collider.CompareTag("w1"))
            {
                sr.sprite = normalS2;
            }
            else
            {
                sr.sprite = normalS; 
            }
        }
    }
}
