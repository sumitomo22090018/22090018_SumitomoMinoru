using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectW : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;

    // Update is called once per frame
    void Update()
    {    var velocity = Vector3.zero;
         velocity.x -= _speed;
        transform.position += transform.rotation * velocity;
    }
}
