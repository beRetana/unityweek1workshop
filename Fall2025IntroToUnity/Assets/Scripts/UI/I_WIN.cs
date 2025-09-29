using UnityEngine;

public class I_WIN : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();


        // Get the camera's orthographic size (half the height of the screen in world units)
        float cameraHeight = Camera.main.orthographicSize * 2f;
        float cameraWidth = cameraHeight * Camera.main.aspect;

        // Get the sprite's original world size
        float spriteWidth = spriteRenderer.sprite.bounds.size.x;
        float spriteHeight = spriteRenderer.sprite.bounds.size.y;

        // Calculate the scale factors
        float scaleX = cameraWidth / spriteWidth;
        float scaleY = cameraHeight / spriteHeight;

        // Apply the new scale to the sprite's transform
        transform.localScale = new Vector3(scaleX, scaleY, 1f);

        // Optional: Center the sprite if it's not already
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
