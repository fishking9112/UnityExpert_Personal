using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI 의 행동을 정리한 클래스 ,
/// Player 에서 특정 행동(UI가 변하는) 행동 시 , PlayerCondition 변화량을 계산 후 , UI 에 전달한다.
/// </summary>

public class Condition : MonoBehaviour
{
    public float curValue;
    public float startValue;
    public float maxValue;
    public bool isPassive = false; // 자연 감소할 변수인지 판단

    public Image uiBar;
    

    void Start()
    {
        curValue = startValue;
    }

    void Update()
    {
        uiBar.fillAmount = GetPercentage();
    }

    float GetPercentage()
    {
        return curValue / maxValue;
    }
    public void Add(float value)
    {
        curValue = Mathf.Min(curValue + value, maxValue);
    }

    public void Subtract(float value)
    {
        curValue = Mathf.Max(curValue - value, 0);
    }

    public void Passive(float value)
    {
        if(isPassive)
        {
            if(value > 0)
            {
                curValue = Mathf.Min(curValue + value, maxValue);
            }
            else if(value < 0)
            {
                //Passive Damage가 음수니까 무조건 더한다 ~
                curValue = Mathf.Max(curValue + value, 0);
            }
            // IsPassive 체크해놓고 , 0으로 두면 값 변동 없음
        }
    }
}
