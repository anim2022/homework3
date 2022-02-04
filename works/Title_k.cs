   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title_k : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))//스페이스바를 누르면
        {
            SceneManager.LoadScene("MainScene");//게임화면으로 움직이기
        }
    }
}
