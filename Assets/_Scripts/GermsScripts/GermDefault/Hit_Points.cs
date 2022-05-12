using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Hit_Points : MonoBehaviour
{
    //Default Value if not set to Component
    public int Hit_Point = 10;

    public int Max_HitPoint = 10;

    public int HitDamage = 1;

    [SerializeField]private AudioSource DiedAudiio;
 
    [SerializeField]public Image image;
    public bool imgEnable;
    /*
 [SerializeField]
 public Sprite GhostSprite;
 */

   


    public Text GermName;
    public GermHealthBarSlider SliderHitpoint;
    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative damage!");
        }
        this.Hit_Point -= amount;

        if (Hit_Point<=0)
        {
            Died();
            
        }
    }

    private async void Died()
    {

        OnPlayMode.Instance.GermsLeft();
        
       
        DiedAudiio.Play();
        Debug.Log(imgEnable);
        Debug.Log("Units dead!");
        await Task.Delay(2000);
        Destroy(gameObject);
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Heal!");
        }
        this.Hit_Point += amount;

        //Limiting heal amount into maximum Hitpoints 
        bool wouldBeOverMaxHP = Hit_Point + amount > Max_HitPoint;
        if (wouldBeOverMaxHP)
        {
            this.Hit_Point = Max_HitPoint;
        }
        else
        {
            this.Hit_Point += amount;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (image.enabled == true)
        {
            imgEnable = true;
        }
        else
        {
            imgEnable = false;
        }
    }

    //Damage take by On click events
    public void HitGerm()
    {
       // Hit = true;
        
        Damage(HitDamage);
        //Changing Germ HP name depend on hitted germ
        SliderHitpoint.SetGermName(name);
        SliderHitpoint.SetHealth(Hit_Point);
        Debug.Log("Damage Taken HP Remaining is " + Hit_Point);
    }
    //Heal given by On clicking objects events
    public void HealGerms()
    {
        Heal(10);
    }




    //Setting the HP Value and also The Germ HP Slider Value
    public void set_HP(int Max_HP, int HP)
    {
        this.Max_HitPoint = Max_HP;
        this.Hit_Point = HP;
        this.SliderHitpoint.SetMaxHealth(Max_HP);
        this.SliderHitpoint.SetHealth(HP);
        
    }
    public void set_GermName(string name)
    {
        GermName.text = name;
    }
}
