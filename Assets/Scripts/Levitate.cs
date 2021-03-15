using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour
{

    [SerializeField] float levitateSpeed = 1f * Time.deltaTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Cannot figure out this logic to make ball levitate back and forth
    void Update()
    {
        // if (gameObject.transform.position.y > 0.05f && gameObject.transform.position.y < 1f) {
        //     transform.Translate(Vector3.up * Time.deltaTime);
        // } else if (gameObject.transform.position.y > 4f) {
        //     transform.Translate(Vector3.down * Time.deltaTime);
        // }
    }
}
