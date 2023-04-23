using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 5f; // Скорость перемещения по осям
    [SerializeField] private float _jumpForce = 5f; // Сила прыжка
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Перемещение по осям
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * _speed * Time.fixedDeltaTime;
        _rb.MovePosition(transform.position + movement);

        // Прыжок
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }
}