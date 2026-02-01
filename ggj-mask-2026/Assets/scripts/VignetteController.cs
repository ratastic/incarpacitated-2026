using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VignetteController : MonoBehaviour
{
    public Volume globalVolume;

    [Header("Pulse Settings")]
    public float min = 0.3f;
    public float max = 0.6f;
    public float speed = 2f;

    private Vignette vignette;

    private void Start()
    {
        if (globalVolume.profile.TryGet(out vignette) == false)
        {
            Debug.LogError("not getting vignetter override");
        }
    }

    private void Update()
    {
        if (vignette == null) return;

        float t = (Mathf.Sin(Time.time * speed) + 1f) / 2f;
        vignette.intensity.value = Mathf.Lerp(min, max, t);
    }
}
