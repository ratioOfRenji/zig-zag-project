using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowPlayer : MonoBehaviour
{
    public GameObject playerr;
    private float smoothSpeed = 0.3f;
    private Vector3 velocity = Vector3.zero;
    private void Update()
    {
     if(player.isPlayerDead == false)
        {
 Vector3 tarhetPosition = playerr.transform.TransformPoint(new Vector3(0, 0, 0));
        tarhetPosition = new Vector3(tarhetPosition.x, 0, tarhetPosition.z);

        transform.position = Vector3.SmoothDamp(transform.position, tarhetPosition, ref velocity, smoothSpeed * Time.deltaTime);
        }
       
    }
}
