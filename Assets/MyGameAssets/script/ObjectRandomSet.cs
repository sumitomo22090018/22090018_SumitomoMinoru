using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRandomSet : MonoBehaviour
{
    [SerializeField]
    GameObject[] objects;
    [SerializeField]
    float timeLimit = 120.0f;//��������

    bool ObjectTimeflg=false;
    float ObjectTimeflgBox=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;//�}�C�t���[�����ɂ����������Ԃ𑫂��Ă���
        if (ObjectTimeflg==false)
        {
            objects[Random.Range(0, objects.Length)].transform.position = ;
            ObjectTimeflgBox = timeLimit;
            ObjectTimeflg = true;
        }
        else if (ObjectTimeflgBox-timeLimit>=5.5)
        {
            
        }

    }
}
