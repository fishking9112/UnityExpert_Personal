using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// UI ( Condition ) �� �����ϴ� ��Ʈ�ѷ�.
/// Player �� Ư�� �ൿ �� , ���⼭ UI�� ���� ���� ( ȣ�� ) ���ش�.
/// </summary>

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;

    Condition HP { get { return uiCondition.HP; } }
    Condition Stamina { get { return uiCondition.Stamina; } }

    [Header("Option")]
    public float passiveDamage;

    void Start()
    {
        
    }

    void Update()
    {

        PassiveDamage();
    }
    void PassiveDamage()
    {
        // ü���� ���� ����
        HP.Passive(passiveDamage * Time.deltaTime);

        if (HP.curValue <= 0f)
            Die();
    }
    void Die()
    {
        Debug.Log("�׾���� �Ф�");
        
        // �ൿ ���ߴ°� �߰�
    }
}
