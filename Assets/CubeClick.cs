using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeClick : MonoBehaviour, IPointerClickHandler {
    int i;

    void Start()
    {
        i = 0;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        gameObject.GetComponent<Renderer>().material.color = color;

        Vector3 pointA = eventData.pointerPressRaycast.worldPosition;
        Vector3 pointB = Camera.main.transform.position;

        Vector3 direction = pointA - pointB;
        direction.Normalize();

        gameObject.GetComponent<Rigidbody>().AddForceAtPosition(direction*500, pointA);

        i++;
        if (i >= 2) Destroy(gameObject);
    }
}
