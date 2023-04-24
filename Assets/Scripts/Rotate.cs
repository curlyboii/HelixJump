using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotateSpeed;
    private float moveX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX= Input.GetAxis("Mouse X");
        if(Input.GetMouseButton(0))
        {
            transform.Rotate(0, rotateSpeed * moveX, 0);

        }
        
    }
}
