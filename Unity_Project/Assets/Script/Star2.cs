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

        // "��"
        // "��"
        // ���� �Ƕ�̵�
        /*

        ��
        �ڡ�
        �ڡڡ�
        �ڡڡڡ�
        �ڡڡڡڡ�

        // ���� ��� �ൿ, ����ġ�� �ൿ
        // ù��° �ٿ����� �� 1��
        // �ι�° �ٿ����� �� 2��

        */

        for (int i = 1; i < 6; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "��";
            }
            star += "\n"; // �� �ٲ�
        }
        // 1,2,3,4,5

        Debug.Log(star);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
