using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CoinScript : MonoBehaviour, IPointerDownHandler, IPointerClickHandler
{
    // Start is called before the first frame update
    public float speedFall;
    public GameObject destination;
    public AudioSource audioSource;

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

   
    void OnGUI()
    {

        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
            
            CoinSpawner.coin += 5;
            StartCoroutine(die());
        }
    }

        public void OnPointerDown(PointerEventData eventData)
    {
    //    audioSource.Play();
        
    //    CoinSpawner.coin=CoinSpawner.coin+10;
    //    StartCoroutine(die());

        
    }



     IEnumerator die()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }

  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*speedFall*Time.deltaTime);
    }
}
