using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContainerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isFull = false;
    public GameManager gameManager;
    private Image image;
    public PlantCardScript plantCardScript;
    public SpawnPoint spawnPoint;
    private void Start()
    {
        image = this.GetComponent<Image>();
        gameManager = GameManager.instance;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            //isFull wrong here
        if (gameManager.draggingGameobject != null && isFull == false)
        {
            gameManager.containerGameobject = this.gameObject;
            //insert plant drop here

            image.enabled = true;
        } }
        
    }
    private void Update()
    {
      
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.containerGameobject = null;
            image.enabled = false;
        }
    }
}
