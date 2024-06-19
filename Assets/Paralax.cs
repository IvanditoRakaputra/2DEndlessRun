using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    RawImage rawImage;
    float distance;

    [Range(0f, 0.5f)]
    public float speed = 0.2f;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
    }

    void Update()
    {
        distance += Time.deltaTime * speed;
        rawImage.uvRect = new Rect(distance, 0, rawImage.uvRect.width, rawImage.uvRect.height);
    }
}
