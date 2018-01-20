using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Dinosaur {

    double Health;

    //Max necessary value of best dino health 
    //A dino needs 1 food per update cycle, etc.
    double Food;
    double Play;
    double Social;
    double Keepers; // 1 or 0 do you have enough keepers
    double Vets; // 1 or 0 do you have enough vets;
    

    //weights that each trait affects overall health
    double fw;
    double pw;
    double sw;
    double vw;
    double kw;

    //Current value of these things to calculate percentage
    double crrHealth;
    double crrFood;
    double crrPlay;
    double crrSocial;
    double crrKeepers;

    //Percentages
    double foodP;
    double playP;
    double socialP;

    //Rates
    double errosionRate;
    double crrErrorsionRate;

    public Dinosaur(double _health, double _food, double _play, double _social, double _keepers, double _errode)
    {
        this.Health = _health;
        this.crrHealth = _health;
        this.Food = _food;
        this.Play = _play;
        this.Social = _social;
        this.Keepers = _keepers;
        this.vw = .2;
        this.kw = .2;
        this.errosionRate = _errode;
    }
    
    /// <summary>
    /// Updates the Dinosaur's health
    /// </summary>
    public void updateDino()
    {
        foodP = crrFood / Food;
        playP = crrPlay / Play;
        socialP = crrSocial / Social;
        double health_weight = (fw * foodP) + (pw * playP) + (sw * socialP) + (vw * Vets) + (kw * Keepers);
        crrHealth -= -10 * (.85 - health_weight);

        double healthP = crrHealth / Health;

		//Errosion is for enclosures. Errosion rate increases based on time away from game.
        if (healthP >= .95)
        {
            crrErrorsionRate = errosionRate * .5;
        } 
        else if (healthP >= .7)
        {
            crrErrorsionRate = errosionRate;
        }
        else if ( healthP >= .4)
        {
            crrErrorsionRate = errosionRate * 2;
        }
        else
        {
            crrErrorsionRate = errosionRate * 3;
        }
    }

    /// <summary>
    /// For setting vets to 1 or 0
    /// </summary>
    /// <param name="x"></param>
    public void UpdateVets(int x)
    {
        Vets = x;
        updateDino();
    }

    /// <summary>
    /// For setting Keepers to 1 or 0
    /// </summary>
    /// <param name="x"></param>
    public void UpdateKeepers(int x)
    {
        Keepers = x;
        updateDino();
    }

    public void UpdatePlay(int x)
    {
        crrPlay = x;
    }

    public void UpdateSocial(int x)
    {
        crrSocial = x;
    }


    public void feedDino(double x)
    {
        crrFood = x;
    }

}
