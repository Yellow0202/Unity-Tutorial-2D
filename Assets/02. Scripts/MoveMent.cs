using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    private void Start()
    {
        //this.transform.position = this.transform.position + Vector3.forward;
    }

    private void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * this.moveSpeed;

        if(Input.GetKey(KeyCode.W) == true)
        {
            this.transform.position += Vector3.forward * this.moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            this.transform.position += Vector3.back * this.moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            this.transform.position += Vector3.left * this.moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            this.transform.position += Vector3.right * this.moveSpeed * Time.deltaTime;
        }
    }
}
