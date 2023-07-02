using UnityEngine;

public class Utils : MonoBehaviour
{
    // Source -> https://youtu.be/XUx_QlJpd0M

    public static Vector3 ScreenToWorld(Camera camera, Vector3 position)
    {
        position.z = camera.nearClipPlane;
        return camera.ScreenToWorldPoint(position);
    }
}
