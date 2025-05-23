using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;

    public float rotSpeed = 30f;    //자전 속도
    public float revolutionSpreed = 100f;   //공전 속도

    public bool isRevolution = false;

    private void Update()
    {
        //자전 기능
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolution == true)
        {
            //공정기능
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpreed * Time.deltaTime);
        }
    }
}
