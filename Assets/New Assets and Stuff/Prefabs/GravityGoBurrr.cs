using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGoBurrr : MonoBehaviour
{
    public Rigidbody rb;

    public bool gravUp = false;

    public bool enemyGravUp = false;

    public float gravForce = 50f;

    public float upwardsRate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Grav Item"))
        {
            if (gravUp == true)
            {
                rb.AddForce(0, gravForce, 0);
            }

            else if (gravUp == false)
            {
                rb.AddForce(0, 0, 0);
            }
        }

        if (gameObject.CompareTag("Enemy Grav"))
        {
            if (enemyGravUp == true)
            {
                this.transform.Translate(Vector3.up * Time.deltaTime * upwardsRate);
            }

            else if (enemyGravUp == false)
            {
                //this.transform.Translate(Vector3.down);
            }
        }
    }

    /*void GravityUp()
    {
        Debug.Log("Gravity going UP!");

        if (gameObject.CompareTag("Enemy Grav"))
        {
            rb.useGravity = true;
        }

        gravUp = true;
    }

    void GravityDown()
    {
        Debug.Log("Gravity going DOWN!");

        gravUp = false;
    }*/

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Grav Projectile")
        {
            gravUp = !gravUp; 

            if (gravUp)
            {
                Debug.Log("Gravity is Going UP!"); 
            }

            else if (!gravUp)
            {
                Debug.Log("Gravity going DOWN!");
            }
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Grav Projectile")
        {
            enemyGravUp = !enemyGravUp;

            if (gravUp)
            {
                Debug.Log("Enemy Gravity is Going UP!");
            }

            else if (!gravUp)
            {
                Debug.Log("Enemy Gravity going DOWN!");
            }
        }
    }
}
