using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI Text_Txt; // �ؽ�Ʈ�� ���� ��
    [SerializeField] TMP_InputField Input_Text; // ��� �ؽ�Ʈ�� ������ ����

    public void OnClickButton()
    {
        Text_Txt.text = Input_Text.text;
    }
}
