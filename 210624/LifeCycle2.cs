using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    void Start(){
        
    }

    void Update(){
        /* 1.오브젝트 이동 */
        // Vector3 vec = new Vector3(0, 0.1f, 0); // 이렇게 x,y,z축 값을 넣어서 초기화함.
        //                                  // Vector2는 2차원, Vector3은 3차원 가리킴.
        // transform.Translate(vec);

        /* 2.입력을 활용한 오브젝트 이동 */
        // Vector3 vec = new Vector3(    // 입력을 해서 오브젝트 이동하게 했음.
	    //     Input.GetAxis("Horizontal"),  // Horizontal 버튼 키인 왼쪽or오른쪽 누르면 x축 이동
	    //     Input.GetAxis("Vertical"),  // Vertical 버튼 키인 위or아래 누르면 y축 이동
	    //     0);   // z축은 0으로 냅뒀음
        // transform.Translate(vec);
    }
}
