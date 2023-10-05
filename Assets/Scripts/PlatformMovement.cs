using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float destroyThreshold;

    private void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
        if (transform.position.x <= destroyThreshold) Destroy(gameObject);
    }
}
