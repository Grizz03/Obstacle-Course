using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        hits++; // Increment hits everytime Player hits object
        Debug.Log($"You hit objects this many times: {hits}");
    }
}
