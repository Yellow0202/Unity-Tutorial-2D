using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    private void Update()
    {
        transform.position += Vector3.forward * bulletSpeed * Time.deltaTime;
    }
}
