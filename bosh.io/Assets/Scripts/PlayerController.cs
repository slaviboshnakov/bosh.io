using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{

    public int score =0;

    public DisplayManager RefDisplayerManager;
    private Vector3 scaleChange = new Vector3(0.005f, 0.005f, 0.005f);

    [SerializeField]
    private List<Sprite> spriteList;

    public float MassProperty
    {
        get
        {
            var parameter = 1 / Mathf.InverseLerp(0f, 10000f, score + 10);
            return parameter;
        }
    }

    void Start()
    {
        if (RefDisplayerManager == null)
        {
            RefDisplayerManager = GetComponentInParent<DisplayManager>();
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0,spriteList.Count)];
        

    }

    private void Update()
    {
        Cell cell = gameObject.GetComponent<Cell>();
        if (Input.GetKey("space"))
        {
            
            if (score==0)
            {
                cell.speed = 0.00325f;
            }
            else
            {
                score -= 1;
                RefDisplayerManager.CurrentScoreText.text = score.ToString();
                gameObject.transform.localScale -= scaleChange;
                
                
                cell.speed = 0.006f;
            }
            
        }

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Food")
        {
            gameObject.transform.localScale += scaleChange;
            score += 1;
            Destroy(other.gameObject);
            RefDisplayerManager.CurrentScoreText.text = score.ToString();
        }
    }
}