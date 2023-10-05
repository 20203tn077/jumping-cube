using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float accelerationFactor;

    void Start() => Time.timeScale = 1;

    void Update() => Time.timeScale += Time.unscaledDeltaTime * accelerationFactor;
}
