using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OtherDogAnimator : MonoBehaviour
{
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene5")) {
            playerAnim.SetBool("Bark_b", false);
            playerAnim.SetFloat("Speed_f", 0.9f);
        }
    }
}
