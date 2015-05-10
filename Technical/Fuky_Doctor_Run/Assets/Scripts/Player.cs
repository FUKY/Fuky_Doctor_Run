using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private Animator playerAnimator;
	private InputController input;
	private Rigidbody2D r2bdPlayer;
	
	public Transform groundCheck;
	public LayerMask layerGround;
	private bool grounded;
	
	void Start()
	{
		playerAnimator = GetComponent<Animator>();
		input = GameObject.Find("Tap").GetComponent<InputController>();
		r2bdPlayer = GetComponent<Rigidbody2D>();
		
	}
	
	void Update()
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, layerGround);
		if (grounded == true && input.tap == true)
		{
			playerAnimator.SetTrigger("jumpPlayer");
			r2bdPlayer.AddForce(new Vector2(0f, 600f));
			input.tap = false;
		}
		if (input.taps>=2)
		{
			Debug.Log("adsfas");
			input.taps = 0;
			playerAnimator.SetTrigger("jump2Player");
		}
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "item") {
			Destroy(col.gameObject);
		}
	}
	
}
