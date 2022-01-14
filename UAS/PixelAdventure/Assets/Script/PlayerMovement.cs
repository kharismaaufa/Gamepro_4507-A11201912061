using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    //Variabel  gerakan horizontal
    float dirX;

    //Variabel untuk kecepatan gerak, dapat diatur inspector
    public float kecepatan = 10f, lompatan = 700f;

    //Referensikan komponen rigidbody
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //Pengoperasian Rigid Body
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");

        if (CrossPlatformInputManager.GetButtonDown ("Jump"))
            Lompat();   
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * kecepatan, rb.velocity.y);
    }

    public void Lompat()
    {
        if (rb.velocity.y == 0f)
            rb.AddForce(new Vector2(0, lompatan), ForceMode2D.Force);
    }

    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("Trap")){
            print("GAME OVER");
            die();
        }
        else if (col.gameObject.tag.Equals ("Finish")){
            print("You WIN!");
            SceneManager.LoadScene("Completion");
        }
    }

    void die(){
        SceneManager.LoadScene("GameOver");
    }

}
