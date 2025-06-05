using System.Collections;
using System.Collections.Generic;
using TMPro; // <- 이걸 써야 먹힌다
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI Txtt_Text; // 작성한 이름에 따라서, 유니티의 설정 이름값도 같이 바뀐다.
    public string NexttText;
    
    public void OnClickButton()
    {
        Txtt_Text.text = NexttText;
    }
}
    