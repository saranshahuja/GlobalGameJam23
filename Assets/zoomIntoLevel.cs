using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomIntoLevel : MonoBehaviour
{
        public Transform level;
        public float zoomSpeed = 1f;

    // Start is called before the first frame update
    void StartZoom()
    {
        Transform.position - level.position;
    }

    // Update is called once per frame
    void Update()
    {
        Transform.position = Vector3.Lerp(Transform.position, level.position, zoomSpeed * Time.deltaTime); 
        Transform.position =    targetPosition;
    }
}
