using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// UI ( Condition ) 을 제어하는 컨트롤러.
/// Player 의 특정 행동 시 , 여기서 UI의 값을 변경 ( 호출 ) 해준다.
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
        // 체력은 지속 감소
        HP.Passive(passiveDamage * Time.deltaTime);

        if (HP.curValue <= 0f)
            Die();
    }
    void Die()
    {
        Debug.Log("죽었어요 ㅠㅠ");
        
        // 행동 멈추는것 추가
    }
}
