using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Set_HP : MonoBehaviour
{
    // �ý��� ��ȹ �����Ѵٰ� �����Ͻð�

    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_Text;

    public Image Img_HPbar;

    public int MaxHP;
    float nowHP;
    // �ּ� ü���� 0

    public int Damage;
    public int HealPoint;

    void Awake()
    {
        �ʱ�ȭ();
    }

    void �ʱ�ȭ() // Initialize();
    {
        nowHP = MaxHP;
        RefreshUI();
    }
    public void OnClickDamage() // ������
    {
        Damage = Random.Range(5, 21); // 5 ~ 21�� ������ �������� ����ǰ� �����

        nowHP -= Damage; // �������� �޴´�
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        {
            nowHP = 0;
        }
        
        Txt_Text.text = $"{Damage}�� �������� �Ծ���.";

        RefreshUI();
        // Img_HPbar.fillAmount = nowHP / MaxHP;
    }

    public void OnClickHealPoint() // ȸ��
    {
        HealPoint = Random.Range(1, 11);

        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }

        Txt_Text.text = $"{HealPoint}�� ȸ���Ͽ���.";

        RefreshUI();
    }
     void RefreshUI() // UI�����ϱ�
    { 
        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // 50 / 100
        // Txt_HP.text = nowHP + "/" MaxHP; // 50 / 100
    }
}
