using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float bulletspeed;
    Rigidbody2D myBody;
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        if(transform.localRotation.z > 0)
        {
            myBody.AddForce(new Vector2(-1, 0) * bulletspeed, ForceMode2D.Impulse);

        }
        else
            myBody.AddForce(new Vector2(1, 0) * bulletspeed, ForceMode2D.Impulse);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
