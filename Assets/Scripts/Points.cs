using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    float points = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"You have {points} points");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        --points;
        Debug.Log($"You have {points} points left");
    }

}
