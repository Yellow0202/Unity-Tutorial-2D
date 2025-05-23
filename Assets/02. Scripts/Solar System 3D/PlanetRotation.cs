using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;

    public float rotSpeed = 30f;    //���� �ӵ�
    public float revolutionSpreed = 100f;   //���� �ӵ�

    public bool isRevolution = false;

    private void Update()
    {
        //���� ���
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolution == true)
        {
            //�������
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpreed * Time.deltaTime);
        }
    }
}
