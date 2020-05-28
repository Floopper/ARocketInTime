using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;
    WeaponSwitcher weaponBehaviour;
    int currentWeapon;
    NavMeshAgent navigation;


    private void Start()
    {
        weaponBehaviour = FindObjectOfType<WeaponSwitcher>();
        currentWeapon = weaponBehaviour.currentWeapon;
        navigation = GetComponentInChildren<EnemyAI>().navMeshAgent;
    }

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;
        if(currentWeapon == 2)
        {
            isDead = true;
            GetComponentInChildren<Animator>().SetTrigger("die");
            navigation.enabled = false;
        } else if(currentWeapon == 1)
        {
            isDead = true;
            GetComponentInChildren<Animator>().SetTrigger("freeze");
            navigation.enabled = false;
        } else if(currentWeapon == 0)
        {
            StartCoroutine(Stunned());
        }
    }

    IEnumerator Stunned()
    {
        if (isDead) { yield break; }
        navigation.enabled = false;
        GetComponentInChildren<Animator>().SetTrigger("stun");
        yield return new WaitForSeconds(3f);
        navigation.enabled = true;
        GetComponentInChildren<Animator>().SetTrigger("move");
        isDead = false;
    }
}