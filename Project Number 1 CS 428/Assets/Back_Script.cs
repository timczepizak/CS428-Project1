using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class Back_Script : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject review1;
    public GameObject review2;
    public GameObject review3;
    public GameObject review4;
    public Transform review1Placement;
    public Transform review2Placement;
    public Transform review3Placement;
    public Transform review4Placement;
    private GameObject video;

    public GameObject Title;

    public GameObject plane;
    public GameObject plane2;
    public VideoPlayer videoReview1;


    public VideoPlayer videoReview2;

    private int stage = 0;
    public GameObject Button;

    // Start is called before the first frame update
    void Start()
    {
        Button = GameObject.Find("Button");
        Button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        stage += 1;
        if (stage == 4)
        {
            stage = 0;
        }

        if (stage == 0)
        {
            video.GetComponent<VideoPlayer>().Stop();
            foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Review"))
            {
                Destroy(gameObject);
            }

            Instantiate(Title, review1Placement);
           

            
        }
        else if(stage == 1)
        {
            foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Review"))
            {
                Destroy(gameObject);
            }
            Debug.Log("Button Pressed");

            

            Instantiate(review1, review1Placement);
            Instantiate(review2, review2Placement);
            Instantiate(review4, review3Placement);
            Instantiate(review3, review4Placement);


        }
        else if (stage == 2)
        {
            foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Review"))
            {
                Destroy(gameObject);
            }
            Debug.Log("Button Pressed");

            Destroy(GameObject.Find("Review 1"));
            Destroy(GameObject.Find("Review 2"));
            Destroy(GameObject.Find("Review 3"));
            Destroy(GameObject.Find("Review 4"));


            video = Instantiate(plane, review2Placement);

            video.GetComponent<VideoPlayer>().Play();



        }
        else if (stage == 3)
        {
            foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Review"))
            {
                Destroy(gameObject);
            }
            Debug.Log("Button Pressed");
            Destroy(GameObject.Find("Plane"));

            video.GetComponent<VideoPlayer>().Stop();
            video = Instantiate(plane2, review2Placement);
            video.GetComponent<VideoPlayer>().Play();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       

    }
}
