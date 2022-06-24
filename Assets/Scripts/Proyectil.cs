using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int speed = 20;
    public Vector3 movimientoBala = new Vector3(0.1f,0,0);
    public int damage = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (movimientoBala * speed * Time.deltaTime);
    }
}
