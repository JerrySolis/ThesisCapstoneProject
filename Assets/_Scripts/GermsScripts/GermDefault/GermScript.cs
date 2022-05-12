using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GermScript : MonoBehaviour
{
    //Default Value if not set to Component
    [SerializeField]private int damage = 5;
    [SerializeField]private float speed = 1.5f;
    [SerializeField]private GermData data;
    [SerializeField]private Button button;
    [SerializeField] private GameObject ghost;
 
    private GameObject player;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Finding Target wound
        player = GameObject.FindGameObjectWithTag("Player");

        //Initial GermEnemy Setup Values
        SetGermEnemyValues();
    }

    // Update is called once per frame
    void Update()
    {
        button.interactable = GetComponent<Hit_Points>().Hit_Point != 0;
        if (GetComponent<Hit_Points>().Hit_Point == 0)
        {
            ghost.SetActive(enabled);
            GetComponent<Hit_Points>().image.enabled = false;
        }
        //Move Enemy Germ to wound when the game starts!
        Swarm();
    }


    //Setting the data stored in GERMDATA hp, damage, and speed
    private void SetGermEnemyValues()
    {
        GetComponent<Hit_Points>().set_GermName(data.Name);
        GetComponent<Hit_Points>().set_HP(data.HP, data.HP);
        damage = data.Damage;
        speed = data.Speed;
    }



    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }





    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {


            if (collider.GetComponent<PlayerHealth>() != null)
            {
                if (ghost.activeInHierarchy.Equals(false))
                {
                    collider.GetComponent<PlayerHealth>().Damage(damage);
                    this.GetComponent<Hit_Points>().Damage(1000);
                    Destroy(gameObject);
                }
            
               
           

               

            }

        }
      
    }




}
