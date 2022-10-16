using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        if (time%10 > 0 && time%10 < 5) {
            Debug.Log("eat");
            playerAnim.SetBool("Eat_b", true);
        }

        else if (time%10 > 5 && time%10 < 10) {
            Debug.Log("no eat");
            playerAnim.SetBool("Eat_b", false);
        }
    }
}
