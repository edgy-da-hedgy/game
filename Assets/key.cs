using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject pathToAppear;

    public GameObject pathToDisapear;
    private void OnTriggerEnter(Collider other)
    {
        if (pathToAppear) pathToAppear.SetActive(true);
        if (pathToDisapear) pathToDisapear.SetActive(false);
        Destroy(gameObject);
             
    }
}
