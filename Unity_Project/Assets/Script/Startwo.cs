using System.Text;
using UnityEngine;
// ������ �۵� Ȯ��
public class Startwo : MonoBehaviour
{
    public int n = 5; // ����Ƽ �ν����Ϳ��� ���� ����

    void Start()
    {
        StringBuilder sb = new StringBuilder();

        // ���� �Ƕ�̵�
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                sb.Append("��");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                sb.Append("��");
            }
            sb.AppendLine();
        }

        // �Ʒ��� �Ƕ�̵�
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                sb.Append("��");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                sb.Append("��");
            }
            sb.AppendLine();
        }

        Debug.Log(sb.ToString());
    }
}