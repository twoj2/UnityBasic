using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
// ¹Ì¿Ï¼º
public class Starone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = int.Parse(Console.ReadLine());
        int powValue = 0;

        for (int i = count; i != 1; i /= 3)
        {
            powValue++;
        }

        StringBuilder sb = new StringBuilder();
        foreach (var i in GetStrings(powValue))
        {
            sb.AppendLine(i);
        }

        Console.WriteLine(sb.ToString());

        string[] GetStrings(int value)
        {
            if (value == 1)
            {
                return new string[]
                {
            "***",
            "* *",
            "***",
                };
            }

            var lowValue = GetStrings(value - 1);
            int lowSize = lowValue.Length;
            string emptyValue = string.Empty;
            for (int i = 0; i < lowSize; i++)
            {
                emptyValue += " ";
            }


            string[] result = new string[lowSize * 3];

            for (int y = 0; y < lowSize; y++)
            {
                result[y] += lowValue[y];
                result[y] += lowValue[y];
                result[y] += lowValue[y];

                result[lowSize * 1 + y] += lowValue[y];
                result[lowSize * 1 + y] += emptyValue;
                result[lowSize * 1 + y] += lowValue[y];

                result[lowSize * 2 + y] += lowValue[y];
                result[lowSize * 2 + y] += lowValue[y];
                result[lowSize * 2 + y] += lowValue[y];
            }

            return result;
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
