using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] Material gotHitMaterial;  // Material to apply when the target is hit

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object tagged as "Bullet"
        if (collision.gameObject.tag == "Bullet")
        {
            // Change the material of the object's MeshRenderer to the hit material
            GetComponent<MeshRenderer>().material = gotHitMaterial;
        }
    }
}
