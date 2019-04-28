using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsScript : MonoBehaviour
{
    float timer;
    public Animator animator;
    public int StopTime = 1;

    // Update is called once per frame

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            //animator.SetTrigger("Active");
            //timer += Time.deltaTime;//Типа запускает таймер
            //animator.SetFloat("Speed", 5.5f); //Я не знаю как но оно запускает анимацию
            //if (timer >= StopTime)
            //{
            //    animator.SetFloat("Speed", 0.5f);//Я не знаю почему но оно не прекращает анимацию
            //}
        }

    }

}
