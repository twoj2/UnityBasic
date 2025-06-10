using System.Text;
using UnityEngine;
//마름모 작동 확인
public class Starfour : MonoBehaviour
{
    public int n = 5; // 피라미드 높이 (인스펙터에서 조절 가능)

    void Start()
    {
        PrintDiamond(n);
    }

    void PrintDiamond(int n)
    {
        StringBuilder sb = new StringBuilder();

        // 위쪽 피라미드
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                sb.Append("　");
            }

            for (int j = 0; j < i * 2 + 1; j++)
            {
                sb.Append("★");
            }

            sb.AppendLine();
        }

        // 아래쪽 피라미드 (거꾸로)
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 0; j < n - i; j++)
            {
                sb.Append("　");
            }

            for (int j = 0; j < i * 2 - 1; j++)
            {
                sb.Append("★");
            }

            sb.AppendLine();
        }

        Debug.Log(sb.ToString());
    }
}