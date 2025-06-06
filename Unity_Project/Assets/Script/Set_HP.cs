using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Set_HP : MonoBehaviour
{
    // 시스템 기획 연습한다고 생각하시고

    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_Text;

    public Image Img_HPbar;

    public int MaxHP;
    float nowHP;
    // 최소 체력은 0

    public int Damage;
    public int HealPoint;

    void Awake()
    {
        초기화();
    }

    void 초기화() // Initialize();
    {
        nowHP = MaxHP;
        RefreshUI();
    }
    public void OnClickDamage() // 데미지
    {
        Damage = Random.Range(5, 21); // 5 ~ 21의 랜덤한 데미지가 적용되게 만들기

        nowHP -= Damage; // 데미지를 받는다
        if (nowHP < 0) // 그런데 0보다 낮아지면 0으로 고정한다.
        {
            nowHP = 0;
        }
        
        Txt_Text.text = $"{Damage}의 데미지를 입었다.";

        RefreshUI();
        // Img_HPbar.fillAmount = nowHP / MaxHP;
    }

    public void OnClickHealPoint() // 회복
    {
        HealPoint = Random.Range(1, 11);

        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }

        Txt_Text.text = $"{HealPoint}를 회복하였다.";

        RefreshUI();
    }
     void RefreshUI() // UI갱신하기
    { 
        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // 50 / 100
        // Txt_HP.text = nowHP + "/" MaxHP; // 50 / 100
    }
}
