using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveRange = 3f;

    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * moveSpeed) * moveRange;
        // Mathf.Sin is for creating a smooth loop
        
        transform.position = startPos + new Vector3(offset, 0f, 0f);
    }
}
