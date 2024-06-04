using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectMoveScript : MonoBehaviour
{
     int PlayerHP=5;
    void OnCollisionStay(Collision other)
    {
       
            Debug.Log(""+PlayerHP);
            PlayerHP--;
       
    }
    void Update()
    {
        if (PlayerHP<=0)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
