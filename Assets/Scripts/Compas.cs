using UnityEngine;

public class Compas : MonoBehaviour
{
    public Transform playerTransform;
    Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        direction.z = playerTransform.eulerAngles.y;
        transform.localEulerAngles = direction;
    }
}
