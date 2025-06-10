using System.Text;
using UnityEngine;
// �Ƕ�̵� Ȯ�� �Ϸ�
public class Starthree : MonoBehaviour
{
    public int height = 5; // �Ƕ�̵� ���� (�� ��), �ν����Ϳ��� ���� ����

    void Start()
    {
        PrintPyramid(height);
    }

    void PrintPyramid(int height)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= height; i++)
        {
            // ���� ���� ���
            for (int j = 1; j <= height - i; j++)
            {
                sb.Append("��");
            }

            // �� ���
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                sb.Append("��");
            }

            // ������ ���� ��� (�����ص� ��翣 ���� ����)
            for (int j = 1; j <= height - i; j++)
            {
                sb.Append("��");
            }

            sb.AppendLine(); // �� �ٲ�
        }

        Debug.Log(sb.ToString());
    }
}

