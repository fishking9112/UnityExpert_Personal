using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICondition : MonoBehaviour
{
    // 상태 Bar를 여기서 묶어서 관리한다.
    public Condition HP;
    public Condition Stamina;

    void Start()
    {
        //플레이어랑 연결
        CharacterManager.Instance.Player.condition.uiCondition = this;
    }
}
