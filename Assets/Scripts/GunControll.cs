using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControll : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    private float _sensitivity = 20;


    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal") * _sensitivity * Time.deltaTime;
        transform.Rotate(0, _horizontal, 0);
        
    }
}
