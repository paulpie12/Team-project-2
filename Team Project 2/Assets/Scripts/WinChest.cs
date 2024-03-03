using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinChest : MonoBehaviour


{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat("Blend", 0);
        animator.SetFloat("MoveY", 0);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            animator.SetFloat("Blend", 1);
            animator.SetFloat("MoveY", 1);
            Invoke("WinMenu", 1);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void WinMenu()
    {
        SceneManager.LoadScene("Win");
    }

}
