using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 0, -5);
    }
}
