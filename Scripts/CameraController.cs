using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraController : MonoBehaviour
{
    public CharacterController char_script;
    public Transform playerTransform;
    public Vector3 offset;
    public float camPositionSpeed = 2f;
    
    void Update()
    {
        
    }
    void LateUpdate()
    {
        Vector3 newCamPosition = new Vector3(playerTransform.position.x + offset.x,playerTransform.position.y + offset.y, playerTransform.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, newCamPosition, camPositionSpeed * Time.deltaTime);
    }
}
