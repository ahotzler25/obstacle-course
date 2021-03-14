using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    new MeshRenderer renderer;
    [SerializeField] float timeToWait = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait && gameObject.tag != "dropBlock") {
            renderer.enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        } else if (Time.time > 10) {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
