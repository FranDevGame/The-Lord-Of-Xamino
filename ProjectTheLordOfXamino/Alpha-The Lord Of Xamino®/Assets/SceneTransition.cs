using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AnimationClip finalAnimation;
    

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
        
        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            //Change Scene

            StartCoroutine("ChangeScene");
        }
    }

    IEnumerator ChangeScene()
    {
        animator.SetTrigger("Init");

        yield return new WaitForSeconds(finalAnimation.length);

        SceneManager.LoadScene(1);
    }
}
