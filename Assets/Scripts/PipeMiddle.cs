using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public GameManagerLogic logic;
    public AudioSource SFX;
    public DumbassFuckingBird bird;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameManagerLogic>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<DumbassFuckingBird>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            if (!bird.birdIsFuckingDead)
            {
                logic.addScore(1);
                SFX.Play();
            }
        }
    }
}
