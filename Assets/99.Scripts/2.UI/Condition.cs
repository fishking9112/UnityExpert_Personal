using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI �� �ൿ�� ������ Ŭ���� ,
/// Player ���� Ư�� �ൿ(UI�� ���ϴ�) �ൿ �� , PlayerCondition ��ȭ���� ��� �� , UI �� �����Ѵ�.
/// </summary>

public class Condition : MonoBehaviour
{
    public float curValue;
    public float startValue;
    public float maxValue;
    public bool isPassive = false; // �ڿ� ������ �������� �Ǵ�

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
                //Passive Damage�� �����ϱ� ������ ���Ѵ� ~
                curValue = Mathf.Max(curValue + value, 0);
            }
            // IsPassive üũ�س��� , 0���� �θ� �� ���� ����
        }
    }
}
