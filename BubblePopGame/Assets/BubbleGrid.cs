using UnityEngine;

public class BubbleGrid : MonoBehaviour
{
    public int rows = 5; // Número de filas (ahora es fijo a 5 como pediste)
    public int cols = 8; // Ajuste de columnas para mantener una buena proporción
    public float bubbleSize = 1.2f; // Tamaño ajustado para mejor espaciado
    public GameObject[] bubblePrefabs;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                SpawnBubble(r, c);
            }
        }
    }

    void SpawnBubble(int r, int c)
    {
        float offsetX = (r % 2 == 0) ? 0f : bubbleSize / 2; // Ajuste de hexágono
        float startX = -(cols / 2f) * bubbleSize + offsetX;
        float startY = 4.5f; // Subir las burbujas más arriba

        Vector2 position = new Vector2(startX + c * bubbleSize, startY - r * (bubbleSize * 0.9f));
        GameObject bubble = Instantiate(
            bubblePrefabs[Random.Range(0, bubblePrefabs.Length)],
            position,
            Quaternion.identity
        );
        bubble.transform.SetParent(transform, true);
    }
}
