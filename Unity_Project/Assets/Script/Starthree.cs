using System.Text;
using UnityEngine;
// 피라미드 확인 완료
public class Starthree : MonoBehaviour
{
    public int height = 5; // 피라미드 높이 (줄 수), 인스펙터에서 변경 가능

    void Start()
    {
        PrintPyramid(height);
    }

    void PrintPyramid(int height)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= height; i++)
        {
            // 왼쪽 공백 출력
            for (int j = 1; j <= height - i; j++)
            {
                sb.Append("　");
            }

            // 별 출력
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                sb.Append("★");
            }

            // 오른쪽 공백 출력 (생략해도 모양엔 영향 없음)
            for (int j = 1; j <= height - i; j++)
            {
                sb.Append("　");
            }

            sb.AppendLine(); // 줄 바꿈
        }

        Debug.Log(sb.ToString());
    }
}

