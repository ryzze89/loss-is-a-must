using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] GameObject interactPrompt;
    [SerializeField] GameObject key;

    void Start()
    {
        interactPrompt.SetActive(false);
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactPrompt.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                interactPrompt.SetActive(false);
                key.SetActive(true);
                Destroy(gameObject);
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactPrompt.SetActive(false);
        }
    }

}
