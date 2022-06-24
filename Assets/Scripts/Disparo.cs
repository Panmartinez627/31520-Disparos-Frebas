
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject prefab; 
    public Transform posicionTorreta;
    // Start is called before the first frame update
    void Start()
    {
         Instantiate(prefab,posicionTorreta.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
