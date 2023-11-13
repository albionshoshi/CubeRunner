using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // rb is a reference to rigidbody that we dragged into component
    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;
    
    // Update is called once per frame
    // Use fixedupdate when using physic componenets
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Added force of 2000 for the z-axis
        
        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime , 0 , 0, ForceMode.VelocityChange); // movement of d key
        }
        
        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime , 0 , 0, ForceMode.VelocityChange); // movement of a key
        }

		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().GameOver(); // if player falls over "Game Over"
		}
    }
}
