using UnityEngine;

public class FPSCamera : MonoBehaviour
{

    public float distance = 10;

    public Transform target;

    float rotationX = 0.0f;
    float rotationY = 0.0f;

    public float mouseSensitivity = 3;

    public Vector2 yMinMax = new Vector2(-85, 85);

    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    public float rotationSmoothTime = .1f;

    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationX += mouseX;
        rotationY -= mouseY;
        //Y角度约束
        rotationY = Mathf.Clamp(rotationY, yMinMax.x, yMinMax.y);
        //旋转镜头
        Vector3 rotation = new Vector3(rotationY, rotationX);

        currentRotation = Vector3.SmoothDamp(currentRotation, rotation, ref rotationSmoothVelocity, rotationSmoothTime);

        transform.eulerAngles = currentRotation;
        //移动镜头
        transform.position = target.position - transform.forward * distance;
    }

}