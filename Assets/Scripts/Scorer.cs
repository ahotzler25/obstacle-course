using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int hits = 0;
    
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Hit" && other.gameObject.tag != "finalTrigger") {
            hits++;
            Debug.Log("You've bumped into an obstacle: " + hits);
        }
    }
}
