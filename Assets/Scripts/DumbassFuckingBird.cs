using UnityEngine;

public class DumbassFuckingBird : MonoBehaviour
{
    public Rigidbody2D myFatFuckingRigidBody;
    public float antiGravity;
    public GameManagerLogic logic;
    public bool birdIsFuckingDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameManagerLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && !birdIsFuckingDead)
        {
            myFatFuckingRigidBody.linearVelocity = Vector2.up * antiGravity;
        }

        if (Mathf.Abs(transform.position.y) > 16f)
        {
            logic.gameOver();
            birdIsFuckingDead = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsFuckingDead = true;
    }
}
