using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("���� �ѹ��� ����˴ϴ�.");
    }

    /* private void OnEnable()
    {
        Debug.Log("Ȱ��ȭ �� �� ����˴ϴ�.");
    }
    // Start is called before the first frame update
    */
/*void Start()
{
    Debug.Log("�ȳ��ϼ���");
    Debug.Log("�ݰ����ϴ�");
    Debug.Log("�ѹ��� ����˴ϴ�.");
}
void OnEnable()
{
    Debug.Log(Random.Range(1, 100));
    // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
}
*/
// Update is called once per frame
/* void Update()
{
    Debug.Log("�� �����Ӹ��� ������ ����˴ϴ�.");
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

    void MonsterSpawn() // ����
    {
        B.SetLevel(A.Level1());
    }
}*/
//}

public class KGA : MonoBehaviour
{
    private string name = "������";
    private int age = 20;
    private float height = 173.9f;
    private string mbti = "INFP";
    private string game = "�¸��� ���� ����";
    private string pastime = "����Ʈ�뺧";
    private string sleep = "��";
    private string hate = "�Ⱦ��մϴ�.";

    void Start()
    {
        SelfIntroduction();
        SelfIntroduction2(name, age, height, pastime, hate);

        Debug.Log("�ȳ��ϼ���");
        Debug.Log("�ݰ����ϴ�");
        Debug.Log("�ѹ��� ����˴ϴ�.");
    }


    public void SelfIntroduction()
    {
        Debug.Log("���� �̸��� " + name + "�Դϴ�.");
        Debug.Log($"���� ���̴� {age}�� �Դϴ�.");
        Debug.Log($"���� MBTI�� {mbti}�Դϴ�.");
        Debug.Log("���� �����ϴ� ������ " + game + "�Դϴ�.");
        Debug.Log("���� �����ϴ� ���� " + sleep + "�ڴ� ���Դϴ�.");
    }

    public void SelfIntroduction2(string _name, int _age, float _height, string _pastime, string _hate)
    {
        Debug.Log("���� �̸��� " + _name + "�Դϴ�.");
        Debug.Log($"���� ���̴� {_age}�� �Դϴ�.");
        Debug.Log("���� Ű�� " + _height + "�Դϴ�.");
        Debug.Log($"���� ��̴� {_pastime} �б� �Դϴ�.");
        Debug.Log("���� ���� ���� " + _hate);
    }
    private void Awake()
    {
        Debug.Log("���� �ѹ��� ����˴ϴ�.");
    }

    void OnEnable()
    {
        Debug.Log("Ȱ��ȭ �� �� ����˴ϴ�.");
        Debug.Log(Random.Range(1, 100));
        // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
    }
    // Start is called before the first frame update
}
