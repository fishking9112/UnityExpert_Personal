using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICondition : MonoBehaviour
{
    // ���� Bar�� ���⼭ ��� �����Ѵ�.
    public Condition HP;
    public Condition Stamina;

    void Start()
    {
        //�÷��̾�� ����
        CharacterManager.Instance.Player.condition.uiCondition = this;
    }
}
