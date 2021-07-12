using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBallTrigger : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)   // 충돌 진행중일때 발생.
        // 매개변수가 Collider인 이유는 물리적인 충돌이 아니기 때문!
    {  
        if(other.name == "Cube"){
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
        // 결과: Cube라는 공간에 가면 OnTriggerStay에 의해서 up방향으로 2씩 이동함.
    }
}
