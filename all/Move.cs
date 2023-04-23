using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 5f; // Скорость перемещения по осям
    [SerializeField] private float _jumpForce = 5f; // Сила прыжка
    private Rigidbody _rb;

    // public GameObject sphere;
    // public int s_scale_x = 1;
    // public int s_scale_y = 1;
    // public int s_scale_z = 1;


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        //sphere.GetComponent<Transform>().scale = (s_scale_x,s_scale_y,s_scale_z);
    }

    private void FixedUpdate()
    {
        // Перемещение по осям
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * _speed * Time.fixedDeltaTime;
        _rb.MovePosition(transform.position + movement);

        //// Прыжок
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        // }
    }
    private void OnCollisionStay(Collision other){
         if (other.gameObject.name == "Platform")
         {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            }
        }
    }
}