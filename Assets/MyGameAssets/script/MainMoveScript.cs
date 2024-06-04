using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 追加しましょう
using UnityEngine.SceneManagement;

public class MainMoveScript : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    public float timeLimit = 120.0f;//制限時間
    void Update()
    {
        timeLimit -= Time.deltaTime;//マイフレーム事にかかった時間を足している
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "制限時間："+timeLimit.ToString("f2");
        if (timeLimit < 0)
        {
            SceneManager.LoadScene("ResultScene");//指定した時間が過ぎたらシーン遷移。("")の中に遷移先のシーンの名前をいれる。
        }

    }
}
