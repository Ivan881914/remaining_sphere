using UnityEngine;

public class Player_x2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Удваиваем массу объекта
            Rigidbody _rb = other.GetComponent<Rigidbody>();
            if (_rb != null)
            {
                _rb.mass *= 3;
            }

            // Изменяем размер объекта
            Transform _tr = other.GetComponent<Transform>();
            if (_tr != null)
            {
                _tr.localScale *= 2;
            }
        }
    }
}