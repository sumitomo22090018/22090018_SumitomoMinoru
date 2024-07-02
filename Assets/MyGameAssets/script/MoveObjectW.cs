using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectW : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;
    private Vector3 _initialPosition; // èâä˙à íu
    private bool _isMoving;
    void Start()
    {
        _initialPosition = gameObject.transform.position;
        Debug.Log(_initialPosition.x + "   x    ");
        if (_initialPosition.x<=3)
        {
            _isMoving = true;
        }
        else
        {
            _isMoving = false;
        }
    }

    // Update is called once per frame
    void Update()
    {    var velocity = Vector3.zero;
       
        if (gameObject.transform.position.x <= -1&&_isMoving==false)
        {
            gameObject.transform.position = _initialPosition; // à íuÇÃèâä˙âª
            Debug.Log(_initialPosition.x + "   x    ");
        }
        else if (gameObject.transform.position.x >= -1 && _isMoving == true)
        {
            gameObject.transform.position = _initialPosition; // à íuÇÃèâä˙âª
            Debug.Log(_initialPosition.x + "   x    ");
        }
        else
        {
            velocity.x -= _speed;
        }

        transform.position += transform.rotation * velocity;
    }
}
