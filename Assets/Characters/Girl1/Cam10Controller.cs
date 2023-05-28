using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam10Controller : MonoBehaviour
{
    public Animator girl1Anim;
    public Animator girl2Anim;
    private float currentTime;
    public float[] times;
    public GameObject textBox;
    public GameObject[] dialogues;
    public GameObject[] girlNames;
    public GameObject border1;
    public GameObject border2;
    public AudioSource sound;
    private bool sound1Played;
    private bool sound2Played;
    private bool sound3Played;
    private bool sound4Played;
    private bool sound5Played;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true)
        {
            currentTime += Time.deltaTime;
            if (currentTime >= 0 && currentTime <= 1)
            {
                textBox.SetActive(true);
                border1.SetActive(true);
                border2.SetActive(true);
            }

            if (currentTime >= times[0] && currentTime <= times[0] + 1)
            {
                girl2Anim.SetBool("araAra", true);
                dialogues[0].SetActive(false);
                dialogues[1].SetActive(true);
                girlNames[0].SetActive(false);
                girlNames[1].SetActive(true);
                if(sound1Played == false)
                {
                    sound.Play();
                    sound1Played = true;
                }
            }

            if (currentTime >= times[1] && currentTime <= times[1] + 1)
            {
                dialogues[1].SetActive(false);
                dialogues[2].SetActive(true);
                girlNames[1].SetActive(false);
                girlNames[0].SetActive(true);
                if (sound2Played == false)
                {
                    sound.Play();
                    sound2Played = true;
                }
            }

            if (currentTime >= times[2] && currentTime <= times[2] + 1)
            {
                girl2Anim.SetBool("shrug", true);
                dialogues[2].SetActive(false);
                dialogues[3].SetActive(true);
                girlNames[0].SetActive(false);
                girlNames[1].SetActive(true);
                if (sound3Played == false)
                {
                    sound.Play();
                    sound3Played = true;
                }
            }
            if (currentTime >= times[3] && currentTime <= times[3] + 1)
            {
                girl1Anim.SetBool("ready", true);
                dialogues[3].SetActive(false);
                dialogues[4].SetActive(true);
                girlNames[1].SetActive(false);
                girlNames[0].SetActive(true);
                if (sound4Played == false)
                {
                    sound.Play();
                    sound4Played = true;
                }
            }
            if (currentTime >= times[4] && currentTime <= times[4] + 1)
            {
                textBox.SetActive(false);
                if (sound5Played == false)
                {
                    sound.Play();
                    sound5Played = true;
                }
            }
        }
    }
}
