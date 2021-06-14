using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
	[Header("Referencias")]
	public Rigidbody2D rb;
	[Header("Mov. Horizontal")]
	public float velocidadeMov = 10;
	float movHorizontal = 0;

	public float for�aPulo = 400f;
	#region Hide
	[Header("Pulo")]
	public CapsuleCollider2D playerCollider;
	public LayerMask groundLayer;
    #endregion

    void Update()
	{
		movHorizontal = Input.GetAxisRaw("Horizontal") * velocidadeMov;
        if (Input.GetKeyDown(KeyCode.Space))
        {              
            rb.AddForce(new Vector2(0f, for�aPulo));
        }
    }
    
    void FixedUpdate()
	{
		Vector3 targetVelocity = new Vector2(movHorizontal, rb.velocity.y);
		rb.velocity = targetVelocity;
	}
	#region Hide 
	private bool TaNoChao()
    {
		RaycastHit2D raycast = Physics2D.Raycast
			(playerCollider.bounds.center, //Origem do raio
			Vector2.down, //Dire��o
			playerCollider.bounds.extents.y + 0.1f, //Tamanho do raio
			groundLayer);
		return raycast.collider != null;
    }
    #endregion
}
