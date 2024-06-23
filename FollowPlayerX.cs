using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2, -10); // Adjust the camera position relative to the plane

    // Update is called once per frame
    void LateUpdate()
    {
        // Follow the plane maintaining the offset
        transform.position = player.transform.position + offset;
        // Keep the camera looking at the plane
        transform.LookAt(player.transform);
    }
}

