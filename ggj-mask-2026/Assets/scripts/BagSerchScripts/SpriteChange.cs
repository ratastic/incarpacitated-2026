using UnityEngine.Audio;
using UnityEngine;

public class HandGrabSpriteChange : MonoBehaviour
{
    [SerializeField] private AudioClip bagAudio;
    private AudioSource bagAudioSrc;

    public SpriteRenderer spriteRenderer;
    public Sprite[] handArray;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        bagAudioSrc = GetComponent<AudioSource>();

        bagAudioSrc.clip = bagAudio;

        bagAudioSrc.playOnAwake = false;
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spriteRenderer.sprite = handArray[1];
            Debug.Log("mouse butt down");

            bagAudioSrc.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            spriteRenderer.sprite = handArray[0];

            bagAudioSrc.Pause();
        }
    }

    //public void OnMouseDown()
    //{
    //    spriteRenderer.sprite = handArray[1];
    //    Debug.Log("mouse butt down");
    //}
    //public void OnMouseUp()
    //{
    //    spriteRenderer.sprite = handArray[0];
    //}
}
