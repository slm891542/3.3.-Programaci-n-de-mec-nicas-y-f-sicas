using System.Collections.Generic;
using UnityEngine;



public class BubbleMatch : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bubble"))
        {
            if (rb != null)
            {
                rb.simulated = false; // Desactivar físicas en lugar de cambiar bodyType
            }

            transform.parent = collision.transform.parent; // Agrupar en el grid
            CheckForMatches();
        }
    }

    void CheckForMatches()
    {
        // Lógica de coincidencia de burbujas por color
        Debug.Log("Verificar coincidencias de color");
    }
}
