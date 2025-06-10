using System.Text;
using UnityEngine;
//������ �۵� Ȯ��
public class Starfour : MonoBehaviour
{
    public int n = 5; // �Ƕ�̵� ���� (�ν����Ϳ��� ���� ����)

    void Start()
    {
        PrintDiamond(n);
    }

    void PrintDiamond(int n)
    {
        StringBuilder sb = new StringBuilder();

        // ���� �Ƕ�̵�
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                sb.Append("��");
            }

            for (int j = 0; j < i * 2 + 1; j++)
            {
                sb.Append("��");
            }

            sb.AppendLine();
        }

        // �Ʒ��� �Ƕ�̵� (�Ųٷ�)
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 0; j < n - i; j++)
            {
                sb.Append("��");
            }

            for (int j = 0; j < i * 2 - 1; j++)
            {
                sb.Append("��");
            }

            sb.AppendLine();
        }

        Debug.Log(sb.ToString());
    }
}