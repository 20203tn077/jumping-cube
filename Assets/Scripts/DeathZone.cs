using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private float stopDelay;
    [SerializeField] private float restartDelay;
    private float _scaleAtDeath;
    private bool _dead;
    private float _passedTime;

    private void Update()
    {
        if (!_dead) return;
        _passedTime += Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Lerp(_scaleAtDeath, 0, 1 / stopDelay * _passedTime);
        if (_passedTime >= restartDelay) SceneManager.LoadScene("Game");
    }

    private void OnTriggerEnter(Collider other)
    {
        _dead = true;
        _scaleAtDeath = Time.timeScale;
    }
}
