using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

//�ȵʾȵ�
public class PlayerAnim : MonoBehaviour
{
    int i;
    float timer;
    int timer2;
  /*  public Text tx;
    public Text count;*/
   /* public TextMeshPro Timer;
    public TextMeshPro Count;*/
    public Animator animator;
    private bool isNowUp = false;
     void Update()
    {
         timer += Time.deltaTime;
        timer2 = (int)(50 - timer);
       if(Input.GetKeyDown(KeyCode.K))
        
        {
            i++;
            AnimBool(true);
            /*  Count.text = "" + i + "/10";*/

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            AnimBool2(true);
        }
        /*else if(i == 10){
            SceneManager.LoadScene("Final");
        }
        else if(timer >= 50f)
        {
            count.text = "�ȼ�";
            SceneManager.LoadScene("Final");
        }
        Timer.text = "Timer : ";
            Timer.text = timer2 +" "+ "sec";*/
        

    }
   
        
    public void AnimBool(bool tmp)
    {
        Debug.Log(tmp);
        isNowUp = !isNowUp;
        var _nextActivationTrigger = isNowUp ? "tUp":"tUp";
        animator.SetTrigger(_nextActivationTrigger);
    }

     public void AnimBool2(bool tmp)
    {
        Debug.Log(tmp);
        isNowUp = !isNowUp;
        var _nextActivationTrigger = isNowUp ? "tDown":"tDown";
        animator.SetTrigger(_nextActivationTrigger);
    }
     
}
