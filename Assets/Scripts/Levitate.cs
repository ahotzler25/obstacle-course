using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour
{

    [SerializeField] float levitateSpeed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > 4f) {
            GetComponent<Rigidbody>().useGravity = true;
            
        }
        if (gameObject.transform.position.y < 1f) {
            GetComponent<Rigidbody>().useGravity = false;
            transform.Translate(0f, levitateSpeed, 0f);
        }
    }
}
