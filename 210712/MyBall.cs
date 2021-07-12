using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    
    void Start() {
        rigid = GetComponent<Rigidbody>();   // Type은 Rigidbody
    }

    void FixedUpdate(){
        // <1.속력 바꾸기>
        // rigid.velocity = Vector3.right;  // 속력을 줬음 + right방향으로 움직이게 함
        // rigid.velocity = new Vector3(2, 4, 3);  // 이렇게 x,y,z축을 줄수도 있음. 이렇게 하면 해당 방향으로 튀는 것 확인가능

        // <2.힘을 가해서 움직이기+버튼입력으로 움직이기>
        /*
        if(Input.GetButtonDown("Jump")){  // 버튼 Jump를 누르면 점프가능!
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);  // 방향은 up, 크기는 5. ForceMode.Impulse를 하면 점프하는것처럼 가능.

            // Debug.Log(rigid.velocity);  // rigid의 속력을 출력.
        }

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        // x축, y축, z축 적용했음
        // GetAxisRaw를 사용해서 -1,0,1값만 가능.
        // Horizontal은 왼쪽-오른쪽. Vertical은 위-아래

        rigid.AddForce(vec, ForceMode.Impulse);
        // 결과: 키보드 방향키로 왼쪽-오른쪽, 위-아래로 이동 가능!
        */

        // <3.회전력>
        rigid.AddTorque(Vector3.up);  // 위를 축으로 삼기 때문에 그냥 같은 위치에서 빙글빙글 돌아감.
        rigid.AddTorque(Vector3.down);  // 아래를 축으로 삼기 때문에 위를 축으로 한것과 반대 방향으로 빙글빙글 돌아감.
    }
}
