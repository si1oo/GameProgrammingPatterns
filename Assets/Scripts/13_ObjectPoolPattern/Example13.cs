using _Example13;
using UnityEngine;

public class Example13 : MonoBehaviour
{
    private BulletPool bulletPool = null;
    Camera cam = null;
    void Start()
    {
        bulletPool = FindFirstObjectByType<BulletPool>();
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateBulletOnMousePosition();
        }
    }

    private void CreateBulletOnMousePosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        float z = 5f;
        mousePosition.z = z;

        Vector3 worldPositon = cam.ScreenToWorldPoint(mousePosition);
        bulletPool.GetBullet(worldPositon, Quaternion.identity, 3f);
    }
}
