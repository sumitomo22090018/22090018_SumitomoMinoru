using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // �ǉ����܂��傤
using UnityEngine.SceneManagement;

public class MainMoveScript : MonoBehaviour
{
    public GameObject score_object = null; // Text�I�u�W�F�N�g
    public float timeLimit = 120.0f;//��������
    void Update()
    {
        timeLimit -= Time.deltaTime;//�}�C�t���[�����ɂ����������Ԃ𑫂��Ă���
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "�������ԁF"+timeLimit.ToString("f2");
        if (timeLimit < 0)
        {
            SceneManager.LoadScene("ResultScene");//�w�肵�����Ԃ��߂�����V�[���J�ځB("")�̒��ɑJ�ڐ�̃V�[���̖��O�������B
        }

    }
}
