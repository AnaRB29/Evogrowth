using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeManager : MonoBehaviour
{
    public float scaleSpeed = 5f;
    private float currentScale = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentScale += 0.2f;
        GameManager.instance.SpawnFood();
        Destroy(collision.gameObject);
        
    }

    private void Update()
    {
        transform.localScale = Vector3.Lerp(a: transform.localScale, b: new Vector3(x: currentScale, y: currentScale, z: 1), t: Time.deltaTime * scaleSpeed);

    }
}
