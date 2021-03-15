using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDrop : MonoBehaviour
{   
    [SerializeField] int playerZPosition = 5;

    private void Start() {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
    }

    private void Update() 
    {
        // Final spheres don't drop until player's z position is past 5 and x position is greater than -5.25
        if (GameObject.FindGameObjectWithTag("Player").transform.position.z > playerZPosition && GameObject.FindGameObjectWithTag("Player").transform.position.x > -5.25) {
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
