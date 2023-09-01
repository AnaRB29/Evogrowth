using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemnet : MonoBehaviour
{
    public Camera cam;
    public float speed = 1f;

    void Update ()
    {
        Vector2 input = Input.mousePosition;
        Vector3 worldInput = cam.ScreenToWorldPoint(input);
        Vector3 newPosition = Vector3.MoveTowards(current: transform.position, target: worldInput, maxDistanceDelta: speed * Time.deltaTime);
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
}
