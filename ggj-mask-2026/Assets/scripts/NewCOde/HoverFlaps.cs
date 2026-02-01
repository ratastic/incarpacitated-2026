using UnityEngine;

public class HoverFlaps : MonoBehaviour
{
    public Sprite normalS;
    public Sprite normalS2;

    public Sprite clickS;

    public Sprite clickS2;

    private SpriteRenderer sr;

    public AudioClip flipFX;
    public AudioClip flipFX2;

    public AudioClip click;
    public AudioClip click2;


    private AudioSource audioSource;

    private bool wasHoveringW1 = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = normalS;
        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 world = Camera.main.ScreenToWorldPoint(mouse);

        world.z = 0f;
        transform.position = world;

        if (Input.GetMouseButton(0)) 
        {
            sr.sprite = clickS;
            if (click != null)
                audioSource.PlayOneShot(click);
            return;

           

        }

        if (Input.GetMouseButton(1))
        {
            sr.sprite = clickS2;
            if (click2 != null)
                audioSource.PlayOneShot(click2);
            return;
          
        }

       
        RaycastHit2D hit = Physics2D.Raycast(world, Vector2.zero);
        bool hoveringW1 = (hit.collider != null && hit.collider.CompareTag("w1"));

        if (hoveringW1 != wasHoveringW1)
        {
            if (hoveringW1)
            {
                sr.sprite = normalS2;
                if (flipFX != null && audioSource != null) audioSource.PlayOneShot(flipFX);
            }
            else
            {
                sr.sprite = normalS;
                if (flipFX2 != null && audioSource != null) audioSource.PlayOneShot(flipFX2);
            }

            wasHoveringW1 = hoveringW1;
        }


        if (!Input.GetMouseButton(0) && !Input.GetMouseButton(1))
        {
            sr.sprite = hoveringW1 ? normalS2 : normalS;
        }


        //if (hit.collider != null && hit.collider.CompareTag("w1"))
        //{
        //    sr.sprite = normalS2;
        //    if (flipFX != null)
        //        audioSource.PlayOneShot(flipFX);
        //}
        //else
        //{
        //    sr.sprite = normalS;
        //    if (flipFX2 != null)
        //        audioSource.PlayOneShot(flipFX2);
        //}
    }
}
