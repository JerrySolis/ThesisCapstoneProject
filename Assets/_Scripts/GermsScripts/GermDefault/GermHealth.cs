using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class GermHealth : MonoBehaviour
{
    [SerializeField] private Image _img, _Died;
    [SerializeField] private Sprite _default;
    [SerializeField] private AudioSource _DiedAudioSource;
    public int health;
    public int currentHealth;

    public GermHealthBarSlider germHealth;
    private void Start()
    {
        currentHealth = health;
        germHealth.SetMaxHealth(health);
    }
    // Update is called once per frame
    void Update()
    {

        if (health < 0)
        {
            //Display died animation
         
            _DiedAudioSource.Play();
            Destroy(gameObject);
            Debug.Log("Germ Died!");
            _Died.gameObject.SetActive(true);
        }
    }
    public void hitted()
    {
        health -= 1;
        germHealth.SetHealth(currentHealth--);
        Debug.Log(health);
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Germ")
        {
            //Destroy(collision.gameObject);
            Debug.Log("Collision happend!!");
        }
    }
    */
}