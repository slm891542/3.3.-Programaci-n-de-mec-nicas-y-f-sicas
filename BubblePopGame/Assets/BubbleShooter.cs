using UnityEngine;

public class BubbleShooter : MonoBehaviour
{
    public GameObject[] bubblePrefabs;
    public Transform shootPoint;
    public float shootForce = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBubble();
        }
    }

    void ShootBubble()
    {
        GameObject bubble = Instantiate(
            bubblePrefabs[Random.Range(0, bubblePrefabs.Length)],
            shootPoint.position,
            Quaternion.identity
        );

        Rigidbody2D rb = bubble.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.gravityScale = 0;
            rb.AddForce((Vector2.up + Vector2.right * Random.Range(-0.2f, 0.2f)) * shootForce, ForceMode2D.Impulse);
        }
    }
}