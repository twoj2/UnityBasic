using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI Text_Txt; // 텍스트를 넣을 곳
    [SerializeField] TMP_InputField Input_Text; // 어디 텍스트를 가지고 올지

    public void OnClickButton()
    {
        Text_Txt.text = Input_Text.text;
    }
}
