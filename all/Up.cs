using UnityEngine;

public class Up : MonoBehaviour
{
    private Rigidbody _rb;

    private void Awake() {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other){

        if (other.gameObject.name == "Up"){
            _rb.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
        }
    }

}
