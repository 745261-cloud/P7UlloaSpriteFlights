using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float minSize = 0.5f;
    float maxSize = 2.0f;
    float minSpeed = 50f;
    float maxSpeed = 250f;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);
        rb = GetComponent<Rigidbody2D>();
        float randomSpeed = randomSize,Range(minSpeed, maxSpeed);
        rb.AddForce(Vector2.right * randomSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
