using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] Canvas DisplayE;
    [SerializeField] GameObject doorCollider;
    [SerializeField] GameObject bomb;
    [SerializeField] Transform placeForBomb;

    private void Start()
    {
        DisplayE.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlantBomb();
        StartCoroutine(ShowCanvas());
    }

    IEnumerator ShowCanvas()
    {
        DisplayE.enabled = true;
        yield return new WaitForSeconds(3f);
        DisplayE.enabled = false;
    }

    public void PlantBomb()
    {
        Instantiate(bomb, placeForBomb);
        doorCollider.SetActive(true);
    }
}
