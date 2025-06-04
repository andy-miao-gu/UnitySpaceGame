using UnityEngine;

public class StarLoader : MonoBehaviour
{
    // Reference to the star prefab
    public GameObject starPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Load the star prefab and star data
        starPrefab = Resources.Load<GameObject>("StarPrefab");
        TextAsset starText = Resources.Load<TextAsset>("stars");
        if (starPrefab == null || starText == null)
        {
            Debug.LogError("StarPrefab or stars.txt not found in Resources!");
            return;
        }

        string[] lines = starText.text.Split('\n');
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            string[] parts = line.Split(',');
            if (parts.Length < 3) continue;

            float x, y, z;
            if (float.TryParse(parts[0], out x) && float.TryParse(parts[1], out y) && float.TryParse(parts[2], out z))
            {
                Instantiate(starPrefab, new Vector3(x, y, z), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}