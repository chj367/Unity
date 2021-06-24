using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle3 : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Start()
    {
        
    }
    void Update()
    {
        // 1.MoveTowards(): 등속 이동. 속도 비례.
	    transform.position = Vector3.MoveTowards(transform.position, target, 1f);

        // 2.SmoothDamp(): 부드럽게 감속 이동. 속도 반비례.
        Vector3 velo = Vector3.zero;   // 참조속도 0이라 했음.

	    transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        // 3.Lerp(): 선형 이동. 속도 비례(최대값은 1)
	    transform.position = Vector3.Lerp(transform.position, target, 0.05f);

        // 4.Slerp(): 포물선 이동. 속도 비례(최대값은 1)
	    transform.position = Vector3.Slerp(transform.position, target, 0.05f);

        // 델타타임(deltaTime)
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0
        );
        transform.Translate(vec);
    }
}
