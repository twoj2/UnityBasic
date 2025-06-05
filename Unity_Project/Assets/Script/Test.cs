using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("최초 한번만 실행됩니다.");
    }

    /* private void OnEnable()
    {
        Debug.Log("활성화 될 때 실행됩니다.");
    }
    // Start is called before the first frame update
    */
/*void Start()
{
    Debug.Log("안녕하세요");
    Debug.Log("반갑습니다");
    Debug.Log("한번만 실행됩니다.");
}
void OnEnable()
{
    Debug.Log(Random.Range(1, 100));
    // 1 이상 100 미만의 랜덤한 값을 만들겠다.
}
*/
// Update is called once per frame
/* void Update()
{
    Debug.Log("매 프레임마다 여러번 실행됩니다.");
}

public class Player
{
    private int playerLevel = 10;

    public int Level1()
    {
        return playerLevel;
    }
}

public class Monster
{
    private int monsterLevel;

    public void SetLevel(int _playerLevel)
    {
        monsterLevel = _playerLevel;
    }
}

public class Game
{
    Player A;
    Monster B;

    void MonsterSpawn() // 몬스터
    {
        B.SetLevel(A.Level1());
    }
}*/
//}

public class KGA : MonoBehaviour
{
    private string name = "조지현";
    private int age = 20;
    private float height = 173.9f;
    private string mbti = "INFP";
    private string game = "승리의 여신 니케";
    private string pastime = "라이트노벨";
    private string sleep = "잠";
    private string hate = "싫어합니다.";

    void Start()
    {
        SelfIntroduction();
        SelfIntroduction2(name, age, height, pastime, hate);

        Debug.Log("안녕하세요");
        Debug.Log("반갑습니다");
        Debug.Log("한번만 실행됩니다.");
    }


    public void SelfIntroduction()
    {
        Debug.Log("저의 이름은 " + name + "입니다.");
        Debug.Log($"저의 나이는 {age}살 입니다.");
        Debug.Log($"저의 MBTI는 {mbti}입니다.");
        Debug.Log("제가 좋아하는 게임은 " + game + "입니다.");
        Debug.Log("제가 좋아하는 것은 " + sleep + "자는 것입니다.");
    }

    public void SelfIntroduction2(string _name, int _age, float _height, string _pastime, string _hate)
    {
        Debug.Log("저의 이름은 " + _name + "입니다.");
        Debug.Log($"저의 나이는 {_age}살 입니다.");
        Debug.Log("저의 키는 " + _height + "입니다.");
        Debug.Log($"제가 취미는 {_pastime} 읽기 입니다.");
        Debug.Log("저는 더운 것을 " + _hate);
    }
    private void Awake()
    {
        Debug.Log("최초 한번만 실행됩니다.");
    }

    void OnEnable()
    {
        Debug.Log("활성화 될 때 실행됩니다.");
        Debug.Log(Random.Range(1, 100));
        // 1 이상 100 미만의 랜덤한 값을 만들겠다.
    }
    // Start is called before the first frame update
}
