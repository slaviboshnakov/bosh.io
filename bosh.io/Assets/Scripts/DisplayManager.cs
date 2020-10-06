using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour
{
    public Text CurrentScoreText;
    public Camera camera;

    private void Start()
    {
        camera = GameObject.Find("camera2").GetComponent<Camera>();
        Destroy(camera);
    }

}