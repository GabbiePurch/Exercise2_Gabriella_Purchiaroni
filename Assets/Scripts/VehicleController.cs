using UnityEngine;
using TMPro;

public class VehicleController : MonoBehaviour
{
    public TextMeshProUGUI GameText;
    [SerializeField] private float movespeed = 10f;
    [SerializeField] private float turnspeed = 700f;
    [SerializeField] private int coin = 0;
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

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            coin += 1;
            GameText.text = "Coins:" + coin;
        }

        if (other.tag == "Boost")
        {
            movespeed += 5;
        }
    }
}
