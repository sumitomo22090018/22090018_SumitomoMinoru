using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playermove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    float speed = 12.0f;
    bool Positioncontrolflg = false;
    //�d�͗p�̕ϐ�
    [SerializeField] private Vector3 localGravity;
    private Rigidbody rBody;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rBody = this.GetComponent<Rigidbody>();
        rBody.useGravity = false; //�ŏ���rigidBody�̏d�͂��g��Ȃ�����
    }

    private void FixedUpdate()
    {
        SetLocalGravity();
    }

    private void SetLocalGravity()
    {
        rBody.AddForce(localGravity, ForceMode.Acceleration);
    }

    //�ڐG����
    void OnCollisionStay(Collision other)
    {
        //�{�[���ɂԂ������Ƃ�
        if (other.gameObject.tag == "floor object")
        {
            
            Positioncontrolflg = true;
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
        Transform myTransform = this.transform;

        // ���[���h���W����ɁA���W���擾
        Vector3 pos = this.transform.position;

        rb.velocity = transform.right * -speed;
        if (pos.z >= 53)
        {
            pos = new Vector3(pos.x, pos.y, 0);
            this.transform.position = pos;

        }
        //�X�y�[�X�L�[�ŃW�����v
        if (Input.GetKey(KeyCode.Space)&& Positioncontrolflg == true)
        {
            rb.velocity = -transform.up *20f;
        }
        // D�L�[�i�E�ړ��j
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = -transform.forward * speed;
        }

        // A�L�[�i���ړ��j
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.forward * speed;
        }
    }

}

