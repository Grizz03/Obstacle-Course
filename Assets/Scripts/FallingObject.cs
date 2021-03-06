using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] float timeToWait = 3;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        rigidBody.useGravity = false;
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToWait)
        {
            rigidBody.useGravity = true;
            renderer.enabled = true;
        }
    }
}
