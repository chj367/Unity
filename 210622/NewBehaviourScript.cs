using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* MonoBehaviour(유니티 게임 오브젝트 클래스)를 상속받았다는 뜻 */
public class NewBehaviourScript : MonoBehaviour
{
    /* 변수를 전역변수로 선언 */
    string title="전설의";
    string playerName="나검사";
    int level=5;
    float strength=15.5f;
    int exp=1500;
    int health=30;
    int mana=25;
    bool isFullLevel=false;
    
    void Start()
    {
        /* 0.기본 출력 */
        Debug.Log("Hello Unity!");

        /* 1.변수+자료형 */
        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);

        /* 2.그룹형 변수(배열) */
        /* (1)자료형[]로 배열 */
        string[] monsters={"슬라임","사막뱀","악마"};
        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        /* (2)배열크기 정해주고 각각 값 넣기 */
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        /* (3)List<> 리스트 */
        List<string> items = new List<string>();
        items.Add("생명물약30");  // 값 추가
        items.Add("마나물약30");
        Debug.Log("가지고 있는 아이템1");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        // items.RemoveAt(0);   // 값 삭제
        // Debug.Log("가지고 있는 아이템2");
        // Debug.Log(items[0]);  // 값 삭제했는데 출력해서 Error 발생!
        // Debug.Log(items[1]);

        /* 3.연산자 */
        /* (1)산술 */
        exp=1500+320;
        exp=exp-10;
        level=exp/300;
        strength=level*3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp=300-(exp%300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        /* (2)문자열 */
        Debug.Log("용사의 이름은?");
        Debug.Log(title+""+playerName);

        /* (3)비교 */
        int fullLevel=99;
        isFullLevel= level==fullLevel;
        Debug.Log("용사는 만렙이니까? "+isFullLevel);

        /* (4)bool-논리 */
        bool isEndTutorial=level>10;
        Debug.Log("튜토리얼이 끝난 용사입니까? "+isEndTutorial);

        /* (3)비교 */
        // int health=30;
        // bool isBadCondition= health<=50 && mana<=20;
        bool isBadCondition= health<=50 || mana<=20;
        Debug.Log("용사의 상태는 나쁩니까? "+isBadCondition);

        /* (5)삼항 */
        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태는 나쁩니까? "+condition);

        /* 4.키워드-생략 */

        /* 5.조건문 */
        /* (1)if-else문 */
        if(condition=="나쁨"){
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        } else {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        /* (2)if-else if문 */
        if(isBadCondition&&items[0]=="생명물약30"){
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if(isBadCondition&&items[0]=="마나물약30"){
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }

        /* (3)switch-case문 + break문 + default문 */
        switch(monsters[0]){   // monster[0]이 슬라임이라서 소형 출력!
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");  
                break;   
            default:
                Debug.Log("??? 몬스터가 출현!");  
                break;   
        }

        /* 6.반복문 */
        /* (1)while문 */
        while(health>0){
            health--;    // 독데미지를 입어서 health가 1씩 반복 감소
            if(health>0){
                Debug.Log("독 데미지를 입었습니다. "+health);
            } else {      // health가 음수가 되면 사망
                Debug.Log("사망하였습니다.");
            }

            if(health==10){
                Debug.Log("해독제를 사용합니다.");
                break;    // health가 10이 되면 break를 만나 반복탈출.
            }
        }

        /* (2)for문 */
        for(int count=0; count<10; count++){
            health++;    // health가 1씩 반복 증가
            Debug.Log("붕대로 치료 중..."+health);
        }

        /* (3)for문으로 배열 반복 */
        for(int index=0; index<monsters.Length; index++){
            Debug.Log("이 지역에 있는 몬스터: "+monsters[index]);
        }    // monsters의 배열 길이크기에 맞게 계속 반복 + 해당 값 반복 출력.

        /* (3-2)foreach문으로 배열 반복 */
        foreach(string monster in monsters){
            Debug.Log("이 지역에 있는 몬스터: "+monster);
        }

        /* 7.함수(메소드) */
        // health = Heal(health);
        Heal();

        for(int index=0; index<monsters.Length; index++){
            Debug.Log("용사는 "+monsters[index]+"에게 "+Battle(monsterLevel[index]));
        }   // monsters에 있는 값을 꺼내서 Battle함수 호출해서 작동함.

        /* 8.클래스+상속 */
        Player player = new Player();  // Player클래스를 객체화해서 사용가능하게 만듦. 이름은 player.
        // Actor클래스를 상속받은 Player클래스라서 그대로 사용 가능.
        player.id =0;
        player.name="나법사";
        player.title="현명한";
        player.strength=2.4f;
        player.weapon="나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name+"의 레벨은 "+player.level+" 입니다.");
        Debug.Log(player.move());
    }

    /* 7.함수(메소드) */
    // int Heal(int currentHealth){
    //     currentHealth +=10;
    //     Debug.Log("힐을 받았습니다. "+currentHealth);
    //     return currentHealth;
    // }

    void Heal(){
        health += 10;
        Debug.Log("힐을 받았습니다. "+health);
    }

    string Battle(int monsterLevel){  
        string result;
        if(level>=monsterLevel){  // 용사레벨이랑 몬스터레벨이랑 비교
            result="이겼습니다.";
        } else {
            result="졌습니다.";
        }
        return result;
    }
}
