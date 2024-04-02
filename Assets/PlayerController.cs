using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float bounds;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currPos = transform.position;
        Vector3 deltaMove = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0); 
        currPos += deltaMove;
        currPos.x = Mathf.Clamp(currPos.x, -bounds, bounds);
        transform.position = currPos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.FromToRotation(new Vector3(1,0,0),new Vector3(0,1,0)));
        }
    }
}
