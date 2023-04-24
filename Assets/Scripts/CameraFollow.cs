using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    public float lerpSpeed; //how smooth we want?

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ball.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, ball.position + offset, lerpSpeed); //smooth transition
        transform.position = newPos;
    }
}
