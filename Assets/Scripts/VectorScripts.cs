using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorScripts : MonoBehaviour
{
    Vector3 velocity = new Vector3(0.3f, 0f, 0.3f);
    void Start()
    {
        Vector3 playerPos = new Vector3(-3.0f, 0f, -4.0f);
        transform.position = playerPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime);
    }
}
