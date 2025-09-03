using UnityEngine;

public class VehicleController : MonoBehaviour
{
    [SerializeField] private float movespeed = 10f;
    [SerializeField] private float turnspeed = 700f;
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
    }

    void Update()
    {
        float move = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime;

        transform.Translate(move, 0, 0);
        transform.Rotate(0, turn, 0);

        //transform.Translate(Vector3.forward * 5f * Time.deltaTime);
        
    }
}
