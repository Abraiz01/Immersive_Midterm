using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerAnimator : MonoBehaviour
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
        // Debug.Log(time%4);

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("TitleScene")) {
            playerAnim.SetBool("Bark_b", false);

            if (time%10 > 0 && time%10 < 7) {
                Debug.Log("eat");
                playerAnim.SetBool("Eat_b", true);
            }

            else if (time%10 > 7 && time%10 < 10) {
                Debug.Log("no eat");
                playerAnim.SetBool("Eat_b", false);
            }
        }

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene0")) {
            if (time%10 > 0 && time%10 < 7) {
                Debug.Log("bark");
                playerAnim.SetBool("Bark_b", true);
            }

            else if (time%10 > 7 && time%10 < 10) {
                Debug.Log("no bark");
                playerAnim.SetBool("Bark_b", false);
            }
        }

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene1")) {
            playerAnim.SetBool("Bark_b", false);
            playerAnim.SetBool("Sit_b", true);
        }

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene2") || SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene8")) {
            playerAnim.SetBool("Bark_b", false);
        }

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene3")) {
            playerAnim.SetBool("Bark_b", true);
            transform.Rotate(80.0f * Time.deltaTime, 100.0f * Time.deltaTime, 120.0f * Time.deltaTime);
        }

        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene6") || SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Scene7")) {
            playerAnim.SetBool("Bark_b", false);
            if (time%10 > 0 && time%10 < 5) {
                Debug.Log("bark");
                playerAnim.SetBool("Bark_b", true);
            }

            else if (time%10 > 5 && time%10 < 10) {
                Debug.Log("no bark");
                playerAnim.SetBool("Bark_b", false);
            }
        }
    }
}
