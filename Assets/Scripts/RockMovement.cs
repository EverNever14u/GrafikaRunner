
using UnityEngine;

public class RockMovement : MonoBehaviour
{

    
    public float speed = 2f;

    Vector3 moveVector = new Vector3(0f, 0f, -1f);

    void Update()
    {
        if (transform.position.z > -20)
        {
            transform.position += moveVector * speed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
