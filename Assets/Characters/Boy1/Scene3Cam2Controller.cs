using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3Cam2Controller : MonoBehaviour
{

    private float currentTime;
    public float[] times;
    public GameObject textBox;
    public GameObject[] dialogues;
    public GameObject[] boyNames;
    public GameObject border1;
    public GameObject border2;
    public AudioSource sound;

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

                dialogues[0].SetActive(false);
                dialogues[1].SetActive(true);
                boyNames[0].SetActive(false);
                boyNames[1].SetActive(true);
            }

            if (currentTime >= times[0] && currentTime <= times[0] + 1)
            {


                textBox.SetActive(false);
                border1.SetActive(false);
                border2.SetActive(false);
            }




        }
    }
}
