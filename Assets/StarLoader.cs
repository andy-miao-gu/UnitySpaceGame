using UnityEngine;

public class StarLoader : MonoBehaviour
{
    public GameObject starPrefab; // Assign in Inspector

    void Start()
    {
        TextAsset starText = Resources.Load<TextAsset>("stars");
        if (starText == null)
        {
            Debug.LogError("stars.txt not found in Resources folder!");
            return;
        }

        string[] starLines = starText.text.Split('\n');

        foreach (string line in starLines)
        {
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("x")) continue;

            string[] parts = line.Trim().Split(',');

            if (parts.Length < 3) continue;

            float x = float.Parse(parts[0]);
            float y = float.Parse(parts[1]);
            float z = float.Parse(parts[2]);

            Vector3 position = new Vector3(x, y, z);
            GameObject star = Instantiate(starPrefab, position, Quaternion.identity);

            // Random scale (size)
            float size = Random.Range(0.1f, 0.4f);
            star.transform.localScale *= size;

            // Random color
            Renderer renderer = star.GetComponent<Renderer>();
            if (renderer != null)
            {
                float r = Random.Range(0.6f, 1f); // brighter range
                float g = Random.Range(0.6f, 1f);
                float b = Random.Range(0.6f, 1f);
                renderer.material.color = new Color(r, g, b);
            }
        }
    }
}
