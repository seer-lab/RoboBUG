using UnityEngine;
using System.Collections;

public class heroControllerScript : MonoBehaviour {

	public float maxSpeed = 10f;
	public float climbSpeed = 1f;
	public Rigidbody2D projectile;
	bool onWall = false;
	bool facingRight = true;
	float fireRate = 2f;
	private float nextFire = 0.0f;
	float animTime = 0.3f;
	private float animDelay = 0.0f;
	Animator anim;
	bool dropping = false;
	float dropTime = 0.3f;
	private float dropDelay = 0.0f;



	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	void FixedUpdate () {

		//movement
		float move = Input.GetAxis ("Horizontal");
		float up = Input.GetAxis ("Vertical");
		if (up > 0) {
			onWall = true;
			rigidbody2D.gravityScale = 0;
		} if (up < 0) {
			onWall = false;
			rigidbody2D.gravityScale = 1;
		}

		//set animation for movement
		anim.SetBool ("onWall", onWall);
		anim.SetFloat ("speed", Mathf.Abs (move));
		anim.SetFloat ("climbSpeed", up);
		if (move > 0) {
			facingRight = true;
		} else if (move < 0) {
			facingRight = false;
		}
		anim.SetBool ("facingRight", facingRight);


		//code for falling down through platforms
		if (Input.GetAxisRaw("Vertical") == -1 && Input.GetButton("Jump")){
			dropDelay = Time.time + dropTime;
			dropping = true;
		}
		if (Time.time > dropDelay){
			dropping = false;
		}
		
		Physics2D.IgnoreLayerCollision(0,8, onWall || dropping);

		//move up if on the wall, otherwise let gravity do the work
		if (dropping) {
			if (rigidbody2D.velocity.y == 0){
			rigidbody2D.isKinematic = true;
			rigidbody2D.AddForce(Vector2.up*-50);
			rigidbody2D.isKinematic = false;
			}
			rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
				} else {
						if (!onWall) {
								rigidbody2D.velocity = new Vector2 (move * maxSpeed, Mathf.Min (0f, rigidbody2D.velocity.y));
						} else {
								rigidbody2D.velocity = new Vector2 (move * maxSpeed, up * climbSpeed);
						}
				}
	}
	void Update(){
	//firing
		if (Input.GetButton ("Fire1") && Time.time > nextFire && !onWall && rigidbody2D.velocity == Vector2.zero) {
			anim.SetBool ("throw", true);
			nextFire = Time.time + fireRate;
			animDelay = Time.time + animTime;
			Rigidbody2D newstar = (Rigidbody2D) Instantiate(projectile, transform.position, transform.rotation);
			if (facingRight){
				newstar.rigidbody2D.AddForce(Vector2.right*300);}
			else{
				newstar.rigidbody2D.AddForce(Vector2.right*-300);}
		}
		if (Time.time > animDelay) {
						anim.SetBool ("throw", false);
				}



	//quit
		if(Input.GetKeyDown(KeyCode.Escape) == true)
		{
			Application.Quit();
		}
	}

}
