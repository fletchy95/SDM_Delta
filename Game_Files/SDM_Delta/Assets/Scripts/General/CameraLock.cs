using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour
{
    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    public Vector3 offset;
    Vector3 targetPos;
    void Start()
    // Runs at start and will determine Avatar's Currnet Position; then go there.  
    {
        targetPos = transform.position;
    }
    void FixedUpdate()
    /* Input: N/A (Runs in place of Update)
     * Purpose: To follow the Avatar gameObject around the map.  It will follow with
     * a slight lag for a nice movement effect.
     */
    {
        if (target)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = target.transform.position.z;
            Vector3 targetDirection = (target.transform.position - posNoZ);
            interpVelocity = targetDirection.magnitude * 10f;
            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);
        }
    }
}