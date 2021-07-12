using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;  // 오브젝트 재질 접근하기-MeshRenderer
    Material mat;   // 재질 설정-Material

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision) // 물리적 충돌 시작.
    {
        if(collision.gameObject.name == "My Ball"){  // 충돌하는 오브젝트 이름이 My Ball일때만 색상이 바뀜.
        // 이렇게 안하면 시작하자마자 색상이 바뀌는데, 바닥도 하나의 오브젝트이기 때문에 충돌하는 것을 정해줬음!
            mat.color = new Color(0,0,0); // 0은 검정색, 1은 흰색
        }
    }

    private void OnCollisionExit(Collision collision) // 물리적 충돌 끝.
    {
        if(collision.gameObject.name == "My Ball"){  
            mat.color = new Color(1,1,1); 
        }
    }
    // 결과: 충돌할때는 검정색, 뗐을때는 흰색으로 바뀌는것 확인가능!
}
