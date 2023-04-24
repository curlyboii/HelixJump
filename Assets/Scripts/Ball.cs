using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;

    public GameObject scoreText;
    public GameObject wonText;

    public GameObject gameOverPanel;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(0, jumpForce,0);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.2f, 0f), Quaternion.Euler(90, 0, 0));
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name; //name material which we collide


        if(materialName == "PlatformSafeMat (Instance)")
        {
            //continue

        }
        else if (materialName == "DangerPlatform (Instance)")
        {
            //gameOver
            gameOverPanel.SetActive(true);
            ball.SetActive(false);
            GameManager.instance.GameOver();


        }
        else if (materialName == "LastRing (Instance)")
        {
            //Win
            scoreText.SetActive(false);
            wonText.SetActive(true);
        }
    }

    public void RestartButton()
    {

        GameManager.instance.RestartGame();

    }
}
