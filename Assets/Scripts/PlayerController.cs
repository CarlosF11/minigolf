using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;
    public Text welcomeText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        welcomeText.text = "WELCOME TO MINI GOLF SIMULATOR! GET 21 CUBES TO WIN THE GAME! USE THE ARROWS OR A-W-S-D TO CONTROL THE BALL";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = count.ToString() + "/21";
        if (count > 0)
        {
            welcomeText.text = "";
        }
        if (count >= 21)
        {
            winText.text = "CONGRATULATIONS! YOU'VE COLLECTED ALL THE CUBES";
        }
    }
}