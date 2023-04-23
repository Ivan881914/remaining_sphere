using UnityEngine;

public class MoveTriggerOnCollision : MonoBehaviour
{
    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.Translate(new Vector3(Random.Range(-2f, 2f), 0, 0));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position = originalPosition;
        }
    }
}