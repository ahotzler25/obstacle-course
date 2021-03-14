using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDrop : MonoBehaviour
{
    bool isTriggered = false;

    // Only the first child is dropping if "Is Trigger" property is unchecked/false
    // Else, no children drop
    private void Update() {
        if (isTriggered == true) {
            gameObject.GetComponentInChildren<Rigidbody>().useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") 
        {
            Debug.Log("Hit final trigger");
            isTriggered = true;
        }
    }
}
