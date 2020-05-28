using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperScript : MonoBehaviour
{
    public void AttackTargetCall()
    {
        EnemyAttack getter = GetComponentInParent<EnemyAttack>();
        getter.AttackHitEvent();
    }
}
