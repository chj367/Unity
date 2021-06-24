using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // void Awake(){    // 초기화 영역
    //     Debug.Log("플레이어 데이터가 준비되었습니다.");
    // }

    // void OnEnable(){  // 활성화
    //     Debug.Log("플레이어가 로그인했습니다.");
    // }

    // void Start(){     // 초기화 영역
    //     Debug.Log("사냥 장비를 챙겼습니다.");
    // }

    // void FixedUpdate() {   // 프레임-물리 영역
    //     Debug.Log("이동~");
    // }
    
    void Update(){   // 프레임-게임로직 영역
        
        /* 1.키 입력 */
        // // anyKeyDown: 아무 입력을 최초로 받을때 호출. true값 적용.
        // if(Input.anyKeyDown){   
        //     Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        // }

        // // anyKey: 아무 입력을 받을때 호출. true값 적용. 
        // if(Input.anyKey) {    
        //     Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        // }

        // // GetKey: 키보드 버튼 입력을 받으면 호출. true값 적용.
        // if(Input.GetKeyDown(KeyCode.Return)) {   // 엔터키+누르면 작동
        //     Debug.Log("아이템을 구입하였습니다.");
        // }

        // if(Input.GetKey(KeyCode.LeftArrow)) {   // 왼쪽 방향키+꾹 누르고있으면 작동
        //     Debug.Log("왼쪽으로 이동 중");
        // }

        // if(Input.GetKeyUp(KeyCode.RightArrow)) {  // 오른쪽 방향키+눌렀다 떼면 작동
        //     Debug.Log("오른쪽 이동을 멈추었습니다.");
        // } 

        // // GetMouse: 마우스 버튼 입력을 받으면 호출. true값 적용.
        // // 매개변수를 0또는 1을 받음. 0은 마우스 왼쪽, 1은 마우스 오른쪽.
        // if(Input.GetMouseButtonDown(0)) {   // 마우스 왼쪽+누르면 작동
        //     Debug.Log("미사일 발사!");
        // }

        // if(Input.GetMouseButton(0)) {     // 마우스 왼쪽+꾹 누르고 있으면 작동
        //     Debug.Log("미사일 모으는 중...");
        // }

        // if(Input.GetMouseButtonUp(0)) {   // 마우스 왼쪽+눌렀다 떼면 작동
        //     Debug.Log("슈퍼 미사일 발사!!");
        // }

        /* 2.버튼 설정+입력 */
        // // GetButton: Input 버튼 입력을 받으면 호출. true값 적용.
        // if(Input.GetButtonDown("Jump")) {   // "Jump"는 유니티-버튼-점프에 있는 이름 적용 연결.
        //     Debug.Log("점프!");           // 스페이스바로 되어있어서, 스페이스바+눌렀을때 작동
        // }

        // if(Input.GetButton("Jump")) {    // 스페이스바+꾹 누르고 있을때 작동
        //     Debug.Log("점프 모으는 중...");
        // }

        // if(Input.GetButtonUp("Jump")) {   // 스페이스바+눌렀다 뗐을때 작동
        //     Debug.Log("슈퍼 점프!!");
        // }

        /* 3.축 입력 */
        // // GetAxis: 수평, 수직 버튼을 입력받으면 호출. float값 반환.
        // if(Input.GetButton("Horizontal")) {  // Horizontal은 유니티-버튼-횡이동 이름 적용 연결.
        //     Debug.Log("횡 이동중....");
        //     Input.GetAxis("Horizontal");
        // }

        // if(Input.GetButton("Vertical")) {  // Vertical은 유니티-버튼-종이동 이름 적용 연결.
        //     Debug.Log("종 이동중....");
        //     Input.GetAxisRaw("Vertical");
        // }
    }

    // void LateUpdate(){  // 프레임-게임로직 영역
    //     Debug.Log("경험치 획득.");
    // }

    // void OnDisable(){  // 비활성화
    //     Debug.Log("플레이어가 로그아웃했습니다.");
    // }

    // void OnDestory(){  // 해체영역
    //     Debug.Log("플레이어 데이터를 해제하였습니다.");
    // }

}
