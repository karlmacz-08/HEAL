using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float speed = 3f;
    public Joystick joystick;

    public int badges = 0;
    public int lastMainDialog = 0;
    public bool isReleasable = false;

    float isRunning = 0f;
    float isCrouching = 0f;
    Rigidbody playerRigidBody;
    Vector3 playerMovement;
    Animator playerAnimator;
    Vector3 directionFacing;

    public void LoadData()
    {
        Player data = SaveManager.LoadPlayer();

        badges = data.badges;
        lastMainDialog = data.lastMainDialog;
        transform.position = new Vector3(data.x, data.y, data.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "Poacher")
        {
            SceneManager.LoadScene("4pics");
        }
    }

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        float h = joystick.Horizontal;
        float v = joystick.Vertical;

        if(h > 0.3f)
        {
            h = 1f;
        }
        else if(h < -0.3f)
        {
            h = -1f;
        }

        if(v > 0.3f)
        {
            v = 1f;
        }
        else if(v < -0.3f)
        {
            v = -1f;
        }

        Move(h, v, isRunning, isCrouching);
        Animate(h, v, isRunning, isCrouching);
    }

    void Move(float h, float v, float r, float c)
    {
        playerMovement.Set(h, 0f, v);

        if(h != 0f || v != 0f)
        {
            directionFacing = new Vector3(h, 0f, v);
        }

        if(r != 0f)
        {
            playerMovement = playerMovement.normalized * speed * 2f * Time.deltaTime;
        }
        else if(c != 0f)
        {
            playerMovement = playerMovement.normalized * speed * 0.25f * Time.deltaTime;
        }
        else
        {
            playerMovement = playerMovement.normalized * speed * Time.deltaTime;
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(directionFacing), 0.5f);
        playerRigidBody.MovePosition(transform.position + playerMovement);
    }

    void Animate(float h, float v, float r, float c)
    {
        playerAnimator.SetBool("is_walking", (h != 0f || v != 0f));
        playerAnimator.SetBool("is_running", ((h != 0f || v != 0f) && r != 0f));
        playerAnimator.SetBool("is_crouching", ((h != 0f || v != 0f) && c != 0f));
    }

    public void RunButtonDown()
    {
        isRunning = 1f;
    }

    public void RunButtonUp()
    {
        isRunning = 0f;
    }

    public void CrouchButtonDown()
    {
        isCrouching = 1f;
    }

    public void CrouchButtonUp()
    {
        isCrouching = 0f;
    }
}
