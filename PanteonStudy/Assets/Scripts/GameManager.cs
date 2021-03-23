using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D.Examples;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameState gameState = GameState.Playing;
    private bool _isPaintingComplete;
    public P3dChannelCounter channelCounter;
    public MeshRenderer Mesh;
    public Material red;
    public Text textActive;
    public Text textDeactive;
    public GameObject fill;
    public Canvas canvas;
    public GameObject confetti;
    public GameObject EndTrigger;
    private void Start()
    {
        canvas.gameObject.SetActive(false);
        confetti.gameObject.SetActive(false);
        Mesh.gameObject.SetActive(false);
    }
    void Update()
    {
        if (gameState == GameState.Over)
        {
            Mesh.gameObject.SetActive(true);
            EndTrigger.gameObject.SetActive(false);
            canvas.gameObject.SetActive(true);
            if (!_isPaintingComplete && channelCounter.RatioA >= 0.5)
            {
                PaintingComplete();
            }
        }
    }
    public void PaintingComplete()
    {
        Mesh.material = red;
        confetti.gameObject.SetActive(true);
        textActive.gameObject.SetActive(false);
        textDeactive.gameObject.SetActive(true);
        fill.gameObject.SetActive(false);
        _isPaintingComplete = true;
    }
}
