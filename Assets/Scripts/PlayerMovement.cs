using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody rb;
    private bool _isGrounded = true;

    private void Update()
    {
        if (_isGrounded && Input.GetKeyDown(KeyCode.Space)) rb.AddForce(Vector3.up * jumpForce);
    }

    private void OnCollisionEnter() => _isGrounded = true;
    private void OnCollisionExit() => _isGrounded = false;
}
