using System.Collections;
using System.Collections.Generic;
using TMPro; // <- �̰� ��� ������
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI Txtt_Text; // �ۼ��� �̸��� ����, ����Ƽ�� ���� �̸����� ���� �ٲ��.
    public string NexttText;
    
    public void OnClickButton()
    {
        Txtt_Text.text = NexttText;
    }
}
    