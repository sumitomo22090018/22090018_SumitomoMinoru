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
    //重力用の変数
    [SerializeField] private Vector3 localGravity;
    private Rigidbody rBody;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rBody = this.GetComponent<Rigidbody>();
        rBody.useGravity = false; //最初にrigidBodyの重力を使わなくする
    }

    private void FixedUpdate()
    {
        SetLocalGravity();
    }

    private void SetLocalGravity()
    {
        rBody.AddForce(localGravity, ForceMode.Acceleration);
    }

    //接触判定
    void OnCollisionStay(Collision other)
    {
        //ボールにぶつかったとき
        if (other.gameObject.tag == "floor object")
        {
            
            Positioncontrolflg = true;
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
        Transform myTransform = this.transform;

        // ワールド座標を基準に、座標を取得
        Vector3 pos = this.transform.position;

        rb.velocity = transform.right * -speed;
        if (pos.z >= 53)
        {
            pos = new Vector3(pos.x, pos.y, 0);
            this.transform.position = pos;

        }
        //スペースキーでジャンプ
        if (Input.GetKey(KeyCode.Space)&& Positioncontrolflg == true)
        {
            rb.velocity = -transform.up *20f;
        }
        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = -transform.forward * speed;
        }

        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.forward * speed;
        }
    }

}

