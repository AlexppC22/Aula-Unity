using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
	[Header("Referencias")]
	public Rigidbody2D rb;
	public Animator playerAnimator;
	[Header("Mov. Horizontal")]
	public float velocidadeMov = 10;
	float movHorizontal = 0;

	public float forçaPulo = 400f;
	#region Hide
	[Header("Pulo")]
	public CapsuleCollider2D playerCollider;
	public LayerMask groundLayer;
	#endregion

	public GameObject pauseMenu;

    void Update()
	{
		movHorizontal = Input.GetAxisRaw("Horizontal") * velocidadeMov;
        if (movHorizontal != 0)
        {
			playerAnimator.SetBool("andando", true);

        }
		else
        {
			playerAnimator.SetBool("andando", false);

        }

		if (Input.GetKeyDown(KeyCode.Space) && TaNoChao())
        {              
            rb.AddForce(new Vector2(0f, forçaPulo));
        }
		if(Input.GetKeyDown(KeyCode.Escape))
        {
			PauseGame();

		}
    }

	public void PauseGame()
    {
		if (pauseMenu.activeInHierarchy)
		{
			Time.timeScale = 1;
			pauseMenu.SetActive(false);
		}
		else	
        {
			pauseMenu.SetActive(true);
			Time.timeScale = 0;
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
			Vector2.down, //Direção
			playerCollider.bounds.extents.y + 0.1f, //Tamanho do raio
			groundLayer);
		return raycast.collider != null;
    }
    #endregion
}
