﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInColl : MonoBehaviour {

    private Vector3 startVector;
    private Vector3 startScale;

    public void OnMouseDown()
    {
        gameObject.transform.Find("Strenge").transform.localPosition = new Vector3(-0.762f, 0.049f, -1f);
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = gameObject.GetComponent<Card>().sprites[1];
        gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 2;
        startScale = gameObject.transform.localScale;
        gameObject.transform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
        startVector = gameObject.transform.localPosition;
        gameObject.transform.position = new Vector3(1.5f, 0, -1);
        gameObject.transform.Find("Count").gameObject.SetActive(false);
    }

    public void OnMouseUp()
    {
        gameObject.transform.Find("Strenge").transform.localPosition = new Vector3(-0.754f, -0.665f, -1f);
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = gameObject.GetComponent<Card>().sprites[0];
        gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 1;
        gameObject.transform.localScale = startScale;
        gameObject.transform.localPosition = startVector;
        gameObject.transform.Find("Count").gameObject.SetActive(true);
    }
}
