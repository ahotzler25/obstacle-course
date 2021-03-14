using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
       PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        
        MovePlayer();
    }

    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game.");
        // Debug.Log("Press A or D to move left and right.");
        // Debug.Log("Press W or S to move forward and backward.");
        // Debug.Log("Don't touch the walls or obstacles.");    
    }

    void MovePlayer() {
        // * Time.deltaTime makes game "framerate independent" (behaves same on fast and slow computers)
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0f, zValue);
    }
};
