using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class playermovement : MonoBehaviour
{
    public float movespeed = 5f;

    public float minX = -14f;
    public float maxX = 14f;
    public float minZ = -14f;
    public float maxZ = 14f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = new Vector3(x, 0f, z).normalized;

        Vector3 nextposition = transform.position + moveDir * movespeed * Time.deltaTime;

        nextposition.x = Mathf.Clamp(nextposition.x, minX, maxX);
        nextposition.z = Mathf.Clamp(nextposition.z, minZ, maxZ);

        transform.position = nextposition;

        if (moveDir != Vector3.zero)
        {
            transform.forward = moveDir;
        }
    }
}