using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectW : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;
    private Vector3 _initialPosition; // 初期位置
    private bool _isMoving;
    void Start()
    {
        _initialPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {    var velocity = Vector3.zero;
        velocity.x -= _speed;
        if (velocity.x - _initialPosition.x <= -3)
        {
            gameObject.transform.position = _initialPosition; // 位置の初期化

        }
        transform.position += transform.rotation * velocity;
    }
}
