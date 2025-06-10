using System.Text;
using UnityEngine;
// 마름모 작동 확인
public class Startwo : MonoBehaviour
{
    public int n = 5; // 유니티 인스펙터에서 조절 가능

    void Start()
    {
        StringBuilder sb = new StringBuilder();

        // 위쪽 피라미드
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                sb.Append("　");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                sb.Append("★");
            }
            sb.AppendLine();
        }

        // 아래쪽 피라미드
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                sb.Append("　");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                sb.Append("★");
            }
            sb.AppendLine();
        }

        Debug.Log(sb.ToString());
    }
}