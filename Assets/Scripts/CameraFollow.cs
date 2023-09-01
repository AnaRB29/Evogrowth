using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float speedScale;
    public Camera cam;

    private void Update()
    {
        Vector3 positionLerp = Vector3.Lerp(a: transform.position, b: target.position, t: Time.deltaTime * speed);
        positionLerp.z = transform.position.z;
        transform.position = positionLerp;
        cam.orthographicSize = Mathf.Lerp(a: cam.orthographicSize, b: 5 * target.localScale.x, t: speedScale * Time.deltaTime);
    }
}
