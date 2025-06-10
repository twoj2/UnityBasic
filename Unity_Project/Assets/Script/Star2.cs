using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Phase1();
    }
    public void Phase1()
    {
        string star = string.Empty; // ""

        // "★"
        // "　"
        // 위쪽 피라미드
        /*

        ★
        ★★
        ★★★
        ★★★★
        ★★★★★

        // 별을 찍는 행동, 엔터치는 행동
        // 첫번째 줄에서는 별 1번
        // 두번째 줄에서는 별 2번

        */

        for (int i = 1; i < 6; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n"; // 줄 바꿈
        }
        // 1,2,3,4,5

        Debug.Log(star);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
