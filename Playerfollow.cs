using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    [SerializeField] private Transform player;     // Reference to the player's Transform
    [SerializeField] private float followDistance = 5.0f;  // Distance to maintain behind the player
    [SerializeField] private float smoothSpeed = 0.125f;    // Speed of the smooth following effect

    private void Update()
    {
        // Define the desired position behind the player
        Vector3 desiredPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z - followDistance);

        // Smoothly move towards the desired position using Lerp
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    }
}
