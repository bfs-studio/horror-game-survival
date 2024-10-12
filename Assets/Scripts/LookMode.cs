using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;


public class LookMode : MonoBehaviour
{
    private PostProcessVolume vol;
    public PostProcessProfile standart;
    public PostProcessProfile nightVision;
    public GameObject nightVisionOverlay;
    private bool nightVisionOn = false;

    // Start is called before the first frame update
    void Start()
    {
        vol = GetComponent<PostProcessVolume>();
        nightVisionOverlay.SetActive(false);
        vol.profile = standart;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.N))
        {
            if (nightVisionOn == false)
            {
                nightVisionOverlay.SetActive(true);
                vol.profile = nightVision;
                nightVisionOn = true;
            }
            else if (nightVisionOn == true)
            {
                nightVisionOverlay.SetActive(false);
                vol.profile = standart;
                this.gameObject.GetComponent<Camera>().fieldOfView = 60;
                nightVisionOn = false;
            }
        }
    }
}
