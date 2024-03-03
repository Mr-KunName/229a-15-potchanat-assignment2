using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    [SerializeField] private float MS;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MV = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce(MV * MS);
    }
}
