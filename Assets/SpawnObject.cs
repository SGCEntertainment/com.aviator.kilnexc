using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);
    }
}
