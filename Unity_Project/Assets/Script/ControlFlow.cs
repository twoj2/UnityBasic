using System.Collections;
using System.Collections.Generic;
using System.Threading;


using UnityEngine;

public class ControlFlow : MonoBehaviour
{

    int count;
    private void Awake()
    {
        count = 0;
    }

    // 업 다운
    // 랜덤한 수 1 ~ 100 사이에 값을 만들고
    // 정답을 맞출때 까지 반복한다.

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("가챠(뽑기)가 실행됐어요~:)");
        }
        // i = 0 , 0 < 5
        //Debug.Log("반복문이 실행됐어요~:)");

    }
    /*
    public void Gacha()
    {
        // 확률이 10%면 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 나머지 70% 확률로 '치치'를 뽑아버렸다!

        int randomValue = Random.Range(1, 101); // 1이상 100미만의 랜덤한 값을 받아오겠다. (1~100)

        Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");
        // count 81
        if (8 <= count) //(10%의 확률) 1 ~ 10
        {
            Debug.Log("확정적으로 '각청'을 뽑았다!");
            count = 0;
        }
        else if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'각청'을 뽑았다!");
        }
        else if (randomValue <= 30) //(20%의 확률) 11 ~ 30
        {
            Debug.Log("'모나'를 뽑았다!");
        }
        else //(70%의 확률)
        {
            Debug.Log("'치치를 뽑아버렸다!");
        }
        count++;
    }
    /*
    public void GachaSwitch()
    {
        // 확률이 10%면 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 나머지 70% 확률로 '치치'를 뽑아버렸다!

        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'각청'을 뽑았다!");
        }
        else if (randomValue <= 30) ; // 11 ~ 30 -> 20%
    }
    */
    public int selectNumbe = 5;
    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        // int selectNumbe = 0;

        switch (selectNumbe) //0
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // 픽업 캐릭 : 이번 뽑기에 확률이 높게  설정되는 캐릭터
                        // 유저들이 특정 캐릭터를 목표하고 뽑게 만드는 시스템
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 2:
                // 분홍 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'분홍 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            default:
                // 파란 머리 꼬마 캐릭터가 나온다.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리 꼬마'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;
        }
    }
}
