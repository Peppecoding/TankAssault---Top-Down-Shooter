using System.Collections;          // Import the System.Collections namespace (used for working with non-generic collections such as ArrayList)
using System.Collections.Generic;  // Import the System.Collections.Generic namespace (used for generic collections like List<T>, Dictionary<TKey, TValue>)
using UnityEditor;
using UnityEngine;                 // Import the UnityEngine namespace to use Unity's core classes and functions like MonoBehaviour, Rigidbody, and more

public class Player : MonoBehaviour  // Define the Player class, which inherits from MonoBehaviour, allowing it to be attached to GameObjects as a component
{
    // Public variables that can be set in the Unity Inspector
    public Rigidbody rb;  // Reference to the Rigidbody component, needed to apply physics forces like velocity and rotation to the player
    [Header ("Gun data")]

    [SerializeField] private Transform gunPoint;
    [SerializeField] private float bulletSpeed;

    [Header("Movement data")]   // A Unity attribute that creates a header label in the Unity Inspector for better organization of public variables
    public float moveSpeed;     // Speed multiplier for the player's movement; this can be adjusted in the Inspector
    public float rotationSpeed; // Speed multiplier for how quickly the player rotates (turns) left and right; also adjustable in the Inspector

    // Private variables that will hold player input values
    private float verticalInput;   // Holds the player's input for moving forward/backward (vertical axis, e.g., 'W'/'S' keys or joystick up/down)
    private float horizontalInput; // Holds the player's input for turning left/right (horizontal axis, e.g., 'A'/'D' keys or joystick left/right)

    [Header ("Tower data")]
    public Transform towerTransform;
    public float towerRotationSpeed;

    [Header ("Aim data")]
    // Public variables related to the aiming system
    public Transform aimTransform; // Reference to a Transform component that represents where the player is aiming, such as a crosshair or target marker
    public LayerMask whatIsAimMask; // LayerMask to filter which objects the player's aiming ray can interact with (e.g., ignore certain objects)

    // The Update method is called once per frame, ideal for handling input and non-physics updates
    void Update()
    {
        // Call the UpdateAim method to update the aiming position of the player based on the mouse's position on the screen
        UpdateAim();

        if(Input.GetKeyDown(KeyCode.Mouse0))
            Shoot();

        // Capture the player's input for forward/backward movement using Unity's Input system
        verticalInput = Input.GetAxis("Vertical");  // 'Vertical' maps to keys like 'W'/'S' or joystick up/down movement

        // Capture the player's input for turning left/right using Unity's Input system
        horizontalInput = Input.GetAxis("Horizontal");  // 'Horizontal' maps to keys like 'A'/'D' or joystick left/right movement

        // If the player is moving backward (verticalInput is negative), invert the horizontal input
        // This makes steering feel more intuitive when moving backward, reversing left/right controls
        if (verticalInput < 0)
        {
            horizontalInput = -Input.GetAxis("Horizontal");  // Reverse horizontal control when moving backward
        }

        // Call the UpdateAim method again (though it's already called at the start of Update, this may be redundant here)
        UpdateAim();
    }

    // FixedUpdate is called at consistent, fixed intervals and is recommended for physics updates
    private void FixedUpdate()
    {
        // Create a movement vector based on the forward direction of the player, the input from the player, and moveSpeed
        Vector3 movement = transform.forward * moveSpeed * verticalInput;  // Move forward based on player's input and speed

        // Apply the movement vector to the player's Rigidbody, changing the player's velocity
        // This causes the player to physically move in the game world
        rb.velocity = movement;

        // Rotate the player around the Y-axis (up/down axis) based on the horizontal input (e.g., turning left or right)
        transform.Rotate(0, horizontalInput * rotationSpeed, 0);  // Rotate the player to turn left/right

        Vector3 direction = aimTransform.position - towerTransform.position;
        direction.y = 0;

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        towerTransform.rotation = Quaternion.RotateTowards(towerTransform.rotation, targetRotation, towerRotationSpeed);



    }

    private void Shoot() 
    {
    Debug.Log("Phew phew");
    }

    // Method responsible for handling the player's aiming functionality
    private void UpdateAim()
    {
        // Create a ray that originates from the main camera's position and goes through the point where the mouse is on the screen
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  // Converts the mouse position into a point in 3D space

        RaycastHit hit;  // Variable that will store information about what the ray intersects (if anything)

        // Perform a raycast from the camera to see if it hits an object within the scene that is part of the specified aiming layer (whatIsAimMask)
        // The ray will shoot infinitely into the scene, and the LayerMask is used to filter the hit objects
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, whatIsAimMask))
        {
            // If the ray hits an object, fix the Y position of the aim so it stays at the player's height (avoiding vertical fluctuations)
            float fixedY = aimTransform.position.y;  // Maintain the current Y position of the aimTransform

            // Update the position of the aim indicator (aimTransform) to match the hit point (where the ray intersected the object)
            // The X and Z coordinates will be updated to match the hit position, while the Y remains fixed to avoid jumping up/down
            aimTransform.position = new Vector3(hit.point.x, fixedY, hit.point.z);
        }
    }
}
