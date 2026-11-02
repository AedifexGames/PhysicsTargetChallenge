using Unity.VisualScripting;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float distanceToRise = 3f;
    private Vector3 startPos, endPos, targetPos;
    private bool init = true;
    private void Start()
    {
        startPos = transform.position;
        endPos = startPos + distanceToRise * Vector3.up;
        targetPos = endPos;
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, targetPos) < 0.1f)
        {
            targetPos = init ? startPos : endPos; init = !init;
        }
        transform.position = Vector3.Lerp(
            transform.position, 
            targetPos, 
            moveSpeed * Time.deltaTime);
    }
}
