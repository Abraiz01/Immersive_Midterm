using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OtherDogAnimator : MonoBehaviour
{
    private Animator playerAnim;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene5")) {
            playerAnim.SetBool("Bark_b", false);
            playerAnim.SetFloat("Speed_f", 0.9f);
        }

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene6") || SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene7")) {
            if (time%10 > 0 && time%10 < 7) {
                Debug.Log("bark");
                playerAnim.SetBool("Bark_b", true);
            }

            else if (time%10 > 7 && time%10 < 10) {
                Debug.Log("no bark");
                playerAnim.SetBool("Bark_b", false);
            }
        }

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene8")) {
            playerAnim.SetBool("Bark_b", false);
            playerAnim.SetBool("Sit_b", true);
        }
    }
}
