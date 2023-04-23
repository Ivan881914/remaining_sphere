using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLava : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "Lava"){
            Debug.Log("Сгорел");
            Destroy(gameObject);
        }
    }
}
