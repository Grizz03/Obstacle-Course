using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime very important so game is fps dependent
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }


    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls or anything else!");
    }

}
