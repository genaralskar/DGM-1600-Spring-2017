using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour
{
    public float turnSpeed = 50f;

    void Update()
    {
        transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.UpArrow))
            turnSpeed = turnSpeed + 10;

        if(Input.GetKey(KeyCode.DownArrow))
            turnSpeed = turnSpeed - 10;
    }
}