using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SwitchPlanManager : MonoBehaviour
{
    public GameObject onePlan;
    public GameObject twoPlan;
    public string playerName;

    private GameObject findObject;
    private TilemapCollider2D collider2;

    void Start()
    {
        findObject = GameObject.Find(playerName);
        collider2 = twoPlan.GetComponent<TilemapCollider2D>();
        collider2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && onePlan.activeSelf == true)
        {
            onePlan.SetActive(false);
            collider2.enabled = true;
            findObject.transform.position += Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.K) && onePlan.activeSelf == false)
        {
            onePlan.SetActive(true);
            collider2.enabled = false;
            findObject.transform.position -= Vector3.up;
        }
    }
}
