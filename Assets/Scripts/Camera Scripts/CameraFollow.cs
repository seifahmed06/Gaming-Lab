using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float CamreaSpeed;
    public float minX, maxX;
    public float minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Target!=null)
        {
            Vector2 newComPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * CamreaSpeed);
            float CalmpX = Mathf.Clamp(newComPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newComPosition.y, minY, maxY);

            transform.position = new Vector3(CalmpX, ClampY, -10f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
