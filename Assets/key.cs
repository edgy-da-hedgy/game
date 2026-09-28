using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject pathToAppear;
    private void OnTriggerEnter(Collider other)
    {
        pathToAppear.SetActive(true);
        Destroy(gameObject);
             
    }
}
