using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private float genInterval;
    [SerializeField] private float minScale;
    [SerializeField] private float maxScale;
    [SerializeField] private float minHeight;
    [SerializeField] private float maxHeight;

    private void Start() => InvokeRepeating(nameof(GeneratePlatform), 0, genInterval);

    private void GeneratePlatform()
    {
        var platform = Instantiate(platformPrefab, transform);
        var s = platform.transform.localScale;
        var p = platform.transform.position;
        platform.transform.localScale = new Vector3(Random.Range(minScale, maxScale), s.y, s.z);
        platform.transform.position = new Vector3(p.x, Random.Range(minHeight, maxHeight), p.z);
    }
}
