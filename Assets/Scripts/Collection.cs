using UnityEngine;

public class Collection : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.0f;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Debug.Log("Coin Picked Up");
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Boost")
        {
            Debug.Log("Boosted Speed");
            Destroy(other.gameObject);
        }
    }
}
