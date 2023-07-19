using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;
using System;
[Serializable]

public class Data
{
    public double dollar;
    //Shop1
    public double HotdogCounterCost
    {
        get
        {
            return 10 * Pow(1.15, HotdogCounterLevel);
        }
    }
    public double HotdogCounterLevel;
    public float HotdogCounterTimer;
    public float HotdogCounterTimeCap;
    public double HotdogCounterMult;
    public double HotdogCounterPower
    {
        get
        {
            return HotdogCounterLevel * HotdogCounterMult;
        }
    }
    public bool HotdogCounterAuto;
    public float HotdogCounterProfit;

    //Shop2
    public double HotdogCarCost
    {
        get
        {
            return 250 * Pow(1.16, HotdogCarLevel);
        }
    }
    public double HotdogCarLevel;
    public float HotdogCarTimer;
    public float HotdogCarTimeCap;
    public double HotdogCarMult;
    public double HotdogCarPower
    {
        get
        {
            return 10 * HotdogCarLevel * HotdogCarMult;
        }
    }
    public bool HotdogCarAuto;

    //Shop3
    public double HotdogBigRestaurantCost
    {
        get
        {
            return 1875 * Pow(1.17, HotdogBigRestaurantLevel);
        }
    }
    public double HotdogBigRestaurantLevel;
    public float HotdogBigRestaurantTimer;
    public float HotdogBigRestaurantTimeCap;
    public double HotdogBigRestaurantMult;
    public double HotdogBigRestaurantPower
    {
        get
        {
            return 150 * HotdogBigRestaurantLevel * HotdogBigRestaurantMult;
        }
    }
    public bool HotdogBigRestaurantAuto;
    //Shop4
    public double HotdogRestaurantCost
    {
        get
        {
            return 3500 * Pow(1.175, HotdogRestaurantLevel);
        }
    }
    public double HotdogRestaurantLevel;
    public float HotdogRestaurantTimer;
    public float HotdogRestaurantTimeCap;
    public double HotdogRestaurantMult;
    public double HotdogRestaurantPower
    {
        get
        {
            return 300 * HotdogRestaurantLevel * HotdogRestaurantMult;
        }
    }
    public bool HotdogRestaurantAuto;
    //Shop5
    public double HotdogFrancheiseRestaurantCost
    {
        get
        {
            return 7000 * Pow(1.177, HotdogFrancheiseRestaurantLevel);
        }
    }
    public double HotdogFrancheiseRestaurantLevel;
    public float HotdogFrancheiseRestaurantTimer;
    public float HotdogFrancheiseRestaurantTimeCap;
    public double HotdogFrancheiseRestaurantMult;
    public double HotdogFrancheiseRestaurantPower
    {
        get
        {
            return 450 * HotdogFrancheiseRestaurantLevel * HotdogFrancheiseRestaurantMult;
        }
    }
    public bool HotdogFrancheiseRestaurantAuto;
    //Shop6
    public double PizzaRestaurantCost
    {
        get
        {
            return 8000 * Pow(1.18, PizzaRestaurantLevel);
        }
    }
    public double PizzaRestaurantLevel;
    public float PizzaRestaurantTimer;
    public float PizzaRestaurantTimeCap;
    public double PizzaRestaurantMult;
    public double PizzaRestaurantPower
    {
        get
        {
            return 600 * PizzaRestaurantLevel * PizzaRestaurantMult;
        }
    }
    public bool PizzaRestaurantAuto;
    //Shop7
    public double PizzaFrancheiseRestaurantCost
    {
        get
        {
            return 10000 * Pow(1.185, PizzaFrancheiseRestaurantLevel);
        }
    }
    public double PizzaFrancheiseRestaurantLevel;
    public float PizzaFrancheiseRestaurantTimer;
    public float PizzaFrancheiseRestaurantTimeCap;
    public double PizzaFrancheiseRestaurantMult;
    public double PizzaFrancheiseRestaurantPower
    {
        get
        {
            return 750 * PizzaFrancheiseRestaurantLevel * PizzaFrancheiseRestaurantMult;
        }
    }
    public bool PizzaFrancheiseRestaurantAuto;
    //Shop8
    public double BurgerRestaurantCost
    {
        get
        {
            return 12500 * Pow(1.19, BurgerRestaurantLevel);
        }
    }
    public double BurgerRestaurantLevel;
    public float BurgerRestaurantTimer;
    public float BurgerRestaurantTimeCap;
    public double BurgerRestaurantMult;
    public double BurgerRestaurantPower
    {
        get
        {
            return 1000 * BurgerRestaurantLevel * BurgerRestaurantMult;
        }
    }
    public bool BurgerRestaurantAuto;
    //Shop9
    public double BurgerFrancheiseRestaurantCost
    {
        get
        {
            return 15000 * Pow(1.195, BurgerFrancheiseRestaurantLevel);
        }
    }
    public double BurgerFrancheiseRestaurantLevel;
    public float BurgerFrancheiseRestaurantTimer;
    public float BurgerFrancheiseRestaurantTimeCap;
    public double BurgerFrancheiseRestaurantMult;
    public double BurgerFrancheiseRestaurantPower
    {
        get
        {
            return 1250 * BurgerFrancheiseRestaurantLevel * BurgerFrancheiseRestaurantMult;
        }
    }
    public bool BurgerFrancheiseRestaurantAuto;
    //Shop10
    public double SushiRestaurantCost
    {
        get
        {
            return 1750 * Pow(1.2, SushiRestaurantLevel);//17500
        }
    }
    public double SushiRestaurantLevel;
    public float SushiRestaurantTimer;
    public float SushiRestaurantTimeCap;
    public double SushiRestaurantMult;
    public double SushiRestaurantPower
    {
        get
        {
            return 200000000000 * SushiRestaurantLevel * SushiRestaurantMult;//1500
        }
    }
    public bool SushiRestaurantAuto;
    //Shop11
    public double SushiFrancheiseRestaurantCost
    {
        get
        {
            return 2000 * Pow(1.21, SushiFrancheiseRestaurantLevel);//22500
        }
    }
    public double SushiFrancheiseRestaurantLevel;
    public float SushiFrancheiseRestaurantTimer;
    public float SushiFrancheiseRestaurantTimeCap;
    public double SushiFrancheiseRestaurantMult;
    public double SushiFrancheiseRestaurantPower
    {
        get
        {
            return 200000000000 * SushiFrancheiseRestaurantLevel * SushiFrancheiseRestaurantMult;//1750
        }
    }
    public bool SushiFrancheiseRestaurantAuto;
    //Shop12
    public double PlaneRestaurantCost
    {
        get
        {
            return 2000 * Pow(1.22, PlaneRestaurantLevel);//25000
        }
    }
    public double PlaneRestaurantLevel;
    public float PlaneRestaurantTimer;
    public float PlaneRestaurantTimeCap;
    public double PlaneRestaurantMult;
    public double PlaneRestaurantPower
    {
        get
        {
            return 200000000000 * PlaneRestaurantLevel * PlaneRestaurantMult;//2000
        }
    }
    public bool PlaneRestaurantAuto;
    //UpgradesHotdogCounterProfit1
    public double UpgradesHotdogCounterCost;
    public double UpgradesHotdogCounterLevel1;
    //UpgradesHotdogCarProfit1
    public double UpgradesHotdogCarCost;
    public double UpgradesHotdogCarLevel1;
    //UpgradesHotdogBigRestaurantProfit1
    public double UpgradesHotdogBigRestaurantCost;
    public double UpgradesHotdogBigRestaurantLevel1;
    //UpgradesHotdogRestaurantProfit1
    public double UpgradesHotdogRestaurantCost;
    public double UpgradesHotdogRestaurantLevel1;
    //UpgradesHotdogFrancheiseRestaurantProfit1
    public double UpgradesHotdogFrancheiseRestaurantCost;
    public double UpgradesHotdogFrancheiseRestaurantLevel1;
    //UpgradesPizzaRestaurantProfit1
    public double UpgradesPizzaRestaurantCost;
    public double UpgradesPizzaRestaurantLevel1;
    //UpgradesPizzzaFrancheiseRestaurantProfit1
    public double UpgradesPizzaFrancheiseRestaurantCost;
    public double UpgradesPizzaFrancheiseRestaurantLevel1;
    //UpgradesBurgerRestaurantProfit1
    public double UpgradesBurgerRestaurantCost;
    public double UpgradesBurgerRestaurantLevel1;
    //UpgradesBurgerFrancheiseRestaurantProfit1
    public double UpgradesBurgerFrancheiseRestaurantCost;
    public double UpgradesBurgerFrancheiseRestaurantLevel1;
    //UpgradesSushiRestaurantProfit1
    public double UpgradesSushiRestaurantCost;
    public double UpgradesSushiRestaurantLevel1;
    //UpgradesSushiFrancheiseRestaurantProfit1
    public double UpgradesSushiFrancheiseRestaurantCost;
    public double UpgradesSushiFrancheiseRestaurantLevel1;
    //UpgradesPlaneRestaurantProfit1
    public double UpgradesPlaneRestaurantCost;
    public double UpgradesPlaneRestaurantLevel1;
    //UpgradesHotdogCounterProfit2
    public double UpgradesHotdogCounterCost2;
    public double UpgradesHotdogCounterLevel2;
    //UpgradesHotdogCarProfit2
    public double UpgradesHotdogCarCost2;
    public double UpgradesHotdogCarLevel2;
    //UpgradesHotdogBigRestaurantProfit2
    public double UpgradesHotdogBigRestaurantCost2;
    public double UpgradesHotdogBigRestaurantLevel2;
    //UpgradesHotdogRestaurantProfit2
    public double UpgradesHotdogRestaurantCost2;
    public double UpgradesHotdogRestaurantLevel2;
    //UpgradesHotdogFrancheiseRestaurantProfit2
    public double UpgradesHotdogFrancheiseRestaurantCost2;
    public double UpgradesHotdogFrancheiseRestaurantLevel2;
    //UpgradesPizzaRestaurantProfit2
    public double UpgradesPizzaRestaurantCost2;
    public double UpgradesPizzaRestaurantLevel2;
    //UpgradesPizzzaFrancheiseRestaurantProfit2
    public double UpgradesPizzaFrancheiseRestaurantCost2;
    public double UpgradesPizzaFrancheiseRestaurantLevel2;
    //UpgradesBurgerRestaurantProfit2
    public double UpgradesBurgerRestaurantCost2;
    public double UpgradesBurgerRestaurantLevel2;
    //UpgradesBurgerFrancheiseRestaurantProfit1
    public double UpgradesBurgerFrancheiseRestaurantCost2;
    public double UpgradesBurgerFrancheiseRestaurantLevel2;
    //UpgradesSushiRestaurantProfit2
    public double UpgradesSushiRestaurantCost2;
    public double UpgradesSushiRestaurantLevel2;
    //UpgradesSushiFrancheiseRestaurantProfit2
    public double UpgradesSushiFrancheiseRestaurantCost2;
    public double UpgradesSushiFrancheiseRestaurantLevel2;
    //UpgradesPlaneRestaurantProfit2
    public double UpgradesPlaneRestaurantCost2;
    public double UpgradesPlaneRestaurantLevel2;
    //UpgradesHotdogCounterProfit3
    public double UpgradesHotdogCounterCost3;
    public double UpgradesHotdogCounterLevel3;
    //UpgradesHotdogCarProfit3
    public double UpgradesHotdogCarCost3;
    public double UpgradesHotdogCarLevel3;
    //UpgradesHotdogBigRestaurantProfit3
    public double UpgradesHotdogBigRestaurantCost3;
    public double UpgradesHotdogBigRestaurantLevel3;
    //UpgradesHotdogRestaurantProfit3
    public double UpgradesHotdogRestaurantCost3;
    public double UpgradesHotdogRestaurantLevel3;
    //UpgradesHotdogFrancheiseRestaurantProfit3
    public double UpgradesHotdogFrancheiseRestaurantCost3;
    public double UpgradesHotdogFrancheiseRestaurantLevel3;
    //UpgradesPizzaRestaurantProfit3
    public double UpgradesPizzaRestaurantCost3;
    public double UpgradesPizzaRestaurantLevel3;
    //UpgradesPizzzaFrancheiseRestaurantProfit3
    public double UpgradesPizzaFrancheiseRestaurantCost3;
    public double UpgradesPizzaFrancheiseRestaurantLevel3;
    //UpgradesBurgerRestaurantProfit3
    public double UpgradesBurgerRestaurantCost3;
    public double UpgradesBurgerRestaurantLevel3;
    //UpgradesBurgerFrancheiseRestaurantProfit3
    public double UpgradesBurgerFrancheiseRestaurantCost3;
    public double UpgradesBurgerFrancheiseRestaurantLevel3;
    //UpgradesSushiRestaurantProfit3
    public double UpgradesSushiRestaurantCost3;
    public double UpgradesSushiRestaurantLevel3;
    //UpgradesSushiFrancheiseRestaurantProfit3
    public double UpgradesSushiFrancheiseRestaurantCost3;
    public double UpgradesSushiFrancheiseRestaurantLevel3;
    //UpgradesPlaneRestaurantProfit3
    public double UpgradesPlaneRestaurantCost3;
    public double UpgradesPlaneRestaurantLevel3;
    //UpgradesHotdogCounterProfit4
    public double UpgradesHotdogCounterCost4;
    public double UpgradesHotdogCounterLevel4;
    //UpgradesHotdogCarProfit4
    public double UpgradesHotdogCarCost4;
    public double UpgradesHotdogCarLevel4;
    //UpgradesHotdogBigRestaurantProfit4
    public double UpgradesHotdogBigRestaurantCost4;
    public double UpgradesHotdogBigRestaurantLevel4;
    //UpgradesHotdogRestaurantProfit4
    public double UpgradesHotdogRestaurantCost4;
    public double UpgradesHotdogRestaurantLevel4;
    //UpgradesHotdogFrancheiseRestaurantProfit4
    public double UpgradesHotdogFrancheiseRestaurantCost4;
    public double UpgradesHotdogFrancheiseRestaurantLevel4;
    //UpgradesPizzaRestaurantProfit4
    public double UpgradesPizzaRestaurantCost4;
    public double UpgradesPizzaRestaurantLevel4;
    //UpgradesPizzzaFrancheiseRestaurantProfit4
    public double UpgradesPizzaFrancheiseRestaurantCost4;
    public double UpgradesPizzaFrancheiseRestaurantLevel4;
    //UpgradesBurgerRestaurantProfit4
    public double UpgradesBurgerRestaurantCost4;
    public double UpgradesBurgerRestaurantLevel4;
    //UpgradesBurgerFrancheiseRestaurantProfit4
    public double UpgradesBurgerFrancheiseRestaurantCost4;
    public double UpgradesBurgerFrancheiseRestaurantLevel4;
    //UpgradesSushiRestaurantProfit4
    public double UpgradesSushiRestaurantCost4;
    public double UpgradesSushiRestaurantLevel4;
    //UpgradesSushiFrancheiseRestaurantProfit4
    public double UpgradesSushiFrancheiseRestaurantCost4;
    public double UpgradesSushiFrancheiseRestaurantLevel4;
    //UpgradesPlaneRestaurantProfit4
    public double UpgradesPlaneRestaurantCost4;
    public double UpgradesPlaneRestaurantLevel4;
    //HotdogCounterManager
    public double HotdogCounterManagerCost;
    public double HotdogCounterManagerLevel1;
    //HotdogCarManager
    public double HotdogCarManagerCost;
    public double HotdogCarManagerLevel1;
    //HotdogBigRestaurantManager
    public double HotdogBigRestaurantManagerCost;
    public double HotdogBigRestaurantManagerLevel1;
    //HotdogRestaurantManager
    public double HotdogRestaurantManagerCost;
    public double HotdogRestaurantManagerLevel1;
    //HotdogFrancheiseRestaurantManager
    public double HotdogFrancheiseRestaurantManagerCost;
    public double HotdogFrancheiseRestaurantManagerLevel1;
    //PizzaRestaurantManager
    public double PizzaRestaurantManagerCost;
    public double PizzaRestaurantManagerLevel1;
    //PizzaFrancheiseRestaurantManager
    public double PizzaFrancheiseRestaurantManagerCost;
    public double PizzaFrancheiseRestaurantManagerLevel1;
    //BurgerRestaurantManager
    public double BurgerRestaurantManagerCost;
    public double BurgerRestaurantManagerLevel1;
    //BurgerFrancheiseRestaurantManager
    public double BurgerFrancheiseRestaurantManagerCost;
    public double BurgerFrancheiseRestaurantManagerLevel1;
    //SushiRestaurantManager
    public double SushiRestaurantManagerCost;
    public double SushiRestaurantManagerLevel1;
    //SushiFrancheiseRestaurantManager
    public double SushiFrancheiseRestaurantManagerCost;
    public double SushiFrancheiseRestaurantManagerLevel1;
    //PlaneRestaurantManager
    public double PlaneRestaurantManagerCost;
    public double PlaneRestaurantManagerLevel1;

    public Data()
    {
        FullReset();
    }
    public void FullReset()
    {
        dollar = 50000000;
        HotdogCounterTimeCap = 1;
        HotdogCounterTimer = 0;
        HotdogCounterMult = 1;

        HotdogCarTimeCap = 4;
        HotdogCarTimer = 0;
        HotdogCarMult = 1;

        HotdogBigRestaurantTimeCap = 15; 
        HotdogBigRestaurantTimer = 0;
        HotdogBigRestaurantMult = 1;

        HotdogRestaurantTimeCap = 20;
        HotdogRestaurantTimer = 0;
        HotdogRestaurantMult = 1;

        HotdogFrancheiseRestaurantTimeCap = 30;
        HotdogFrancheiseRestaurantTimer = 0;
        HotdogFrancheiseRestaurantMult = 1;

        PizzaRestaurantTimeCap = 45;
        PizzaRestaurantTimer = 0;
        PizzaRestaurantMult = 1;

        PizzaFrancheiseRestaurantTimeCap = 60;
        PizzaFrancheiseRestaurantTimer = 0;
        PizzaFrancheiseRestaurantMult = 1;

        BurgerRestaurantTimeCap = 75;
        BurgerRestaurantTimer = 0;
        BurgerRestaurantMult = 1;

        BurgerFrancheiseRestaurantTimeCap = 90;//90
        BurgerFrancheiseRestaurantTimer = 0;
        BurgerFrancheiseRestaurantMult = 1;

        SushiRestaurantTimeCap = 100;//100
        SushiRestaurantTimer = 0;
        SushiRestaurantMult = 1;

        SushiFrancheiseRestaurantTimeCap = 120;//120
        SushiFrancheiseRestaurantTimer = 0;
        SushiFrancheiseRestaurantMult = 1;

        PlaneRestaurantTimeCap = 150; //150
        PlaneRestaurantTimer = 0;
        PlaneRestaurantMult = 1;

        UpgradesHotdogCounterCost = 1500;
        UpgradesHotdogCarCost = 2000;
        UpgradesHotdogBigRestaurantCost = 3000;
        UpgradesHotdogRestaurantCost = 5000;
        UpgradesHotdogFrancheiseRestaurantCost = 7500;
        UpgradesPizzaRestaurantCost = 8000;
        UpgradesPizzaFrancheiseRestaurantCost = 10000;
        UpgradesBurgerRestaurantCost = 12500;
        UpgradesBurgerFrancheiseRestaurantCost = 15000;
        UpgradesSushiRestaurantCost = 20000;
        UpgradesSushiFrancheiseRestaurantCost = 25000;
        UpgradesPlaneRestaurantCost = 30000;

        UpgradesHotdogCounterCost2 = 35000;
        UpgradesHotdogCarCost2 = 40000;
        UpgradesHotdogBigRestaurantCost2 = 50000;
        UpgradesHotdogRestaurantCost2 = 60000;
        UpgradesHotdogFrancheiseRestaurantCost2 = 75000;
        UpgradesPizzaRestaurantCost2 = 80000;
        UpgradesPizzaFrancheiseRestaurantCost2 = 100000;
        UpgradesBurgerRestaurantCost2 = 125000;
        UpgradesBurgerFrancheiseRestaurantCost2 = 150000;
        UpgradesSushiRestaurantCost2 = 200000;
        UpgradesSushiFrancheiseRestaurantCost2 = 250000;
        UpgradesPlaneRestaurantCost2 = 300000;

        UpgradesHotdogCounterCost3 = 350000;
        UpgradesHotdogCarCost3 = 400000;
        UpgradesHotdogBigRestaurantCost3 = 500000;
        UpgradesHotdogRestaurantCost3 = 600000;
        UpgradesHotdogFrancheiseRestaurantCost3 = 750000;
        UpgradesPizzaRestaurantCost3 = 800000;
        UpgradesPizzaFrancheiseRestaurantCost3 = 1000000;
        UpgradesBurgerRestaurantCost3 = 1250000;
        UpgradesBurgerFrancheiseRestaurantCost3 = 1500000;
        UpgradesSushiRestaurantCost3 = 2000000;
        UpgradesSushiFrancheiseRestaurantCost3 = 2500000;
        UpgradesPlaneRestaurantCost3 = 3000000;

        UpgradesHotdogCounterCost4 = 3500000;
        UpgradesHotdogCarCost4 = 4000000;
        UpgradesHotdogBigRestaurantCost4 = 5000000;
        UpgradesHotdogRestaurantCost4 = 6000000;
        UpgradesHotdogFrancheiseRestaurantCost4 = 7500000;
        UpgradesPizzaRestaurantCost4 = 8000000;
        UpgradesPizzaFrancheiseRestaurantCost4 = 10000000;
        UpgradesBurgerRestaurantCost4 = 12500000;
        UpgradesBurgerFrancheiseRestaurantCost4 = 15000000;
        UpgradesSushiRestaurantCost4 = 20000000;
        UpgradesSushiFrancheiseRestaurantCost4 = 25000000;
        UpgradesPlaneRestaurantCost4 = 30000000;

        HotdogCounterManagerCost = 2000;
        HotdogCarManagerCost = 4000;
        HotdogBigRestaurantManagerCost = 6000;
        HotdogRestaurantManagerCost = 8000;
        HotdogFrancheiseRestaurantManagerCost = 10000;
        PizzaRestaurantManagerCost = 12000;
        PizzaFrancheiseRestaurantManagerCost = 14000;
        BurgerRestaurantManagerCost = 16000;
        BurgerFrancheiseRestaurantManagerCost = 18000;
        SushiRestaurantManagerCost = 20000;
        SushiFrancheiseRestaurantManagerCost = 22000;
        PlaneRestaurantManagerCost = 24000;

    }
}

public class GameController : MonoBehaviour
{
    public Data data;
    public Text DollarText;
    float countdown;
    float second;
    float minute;
    float hour;
    #region UI
    public Text HotdogCounterTitleText;
    public Text HotdogCounterCostText;
    public Text HotdogCounterProductionText;
    public Image HotdogCounterFill;
    public Button HotdogCounterButton;
    public Text HotdogCounterTimerText;

    public Text HotdogCarTitleText;
    public Text HotdogCarCostText;
    public Text HotdogCarProductionText;
    public Image HotdogCarFill;
    public Button HotdogCarButton;
    public Text HotdogCarTimerText;

    public Text HotdogBigRestaurantTitleText;
    public Text HotdogBigRestaurantCostText;
    public Text HotdogBigRestaurantProductionText;
    public Image HotdogBigRestaurantFill;
    public Button HotdogBigRestaurantButton;
    public Text HotdogBigRestaurantTimerText;

    public Text HotdogRestaurantTitleText;
    public Text HotdogRestaurantCostText;
    public Text HotdogRestaurantProductionText;
    public Image HotdogRestaurantFill;
    public Button HotdogRestaurantButton;
    public Text HotdogRestaurantTimerText;

    public Text HotdogFrancheiseRestaurantTitleText;
    public Text HotdogFrancheiseRestaurantCostText;
    public Text HotdogFrancheiseRestaurantProductionText;
    public Image HotdogFrancheiseRestaurantFill;
    public Button HotdogFrancheiseRestaurantButton;
    public Text HotdogFrancheiseRestaurantTimerText;

    public Text PizzaRestaurantTitleText;
    public Text PizzaRestaurantCostText;
    public Text PizzaRestaurantProductionText;
    public Image PizzaRestaurantFill;
    public Button PizzaRestaurantButton;
    public Text PizzaRestaurantTimerText;

    public Text PizzaFrancheiseRestaurantTitleText;
    public Text PizzaFrancheiseRestaurantCostText;
    public Text PizzaFrancheiseRestaurantProductionText;
    public Image PizzaFrancheiseRestaurantFill;
    public Button PizzaFrancheiseRestaurantButton;
    public Text PizzaFrancheiseRestaurantTimerText;

    public Text BurgerRestaurantTitleText;
    public Text BurgerRestaurantCostText;
    public Text BurgerRestaurantProductionText;
    public Image BurgerRestaurantFill;
    public Button BurgerRestaurantButton;
    public Text BurgerRestaurantTimerText;

    public Text BurgerFrancheiseRestaurantTitleText;
    public Text BurgerFrancheiseRestaurantCostText;
    public Text BurgerFrancheiseRestaurantProductionText;
    public Image BurgerFrancheiseRestaurantFill;
    public Button BurgerFrancheiseRestaurantButton;
    public Text BurgerFrancheiseRestaurantTimerText;

    public Text SushiRestaurantTitleText;
    public Text SushiRestaurantCostText;
    public Text SushiRestaurantProductionText;
    public Image SushiRestaurantFill;
    public Button SushiRestaurantButton;
    public Text SushiRestaurantTimerText;

    public Text SushiFrancheiseRestaurantTitleText;
    public Text SushiFrancheiseRestaurantCostText;
    public Text SushiFrancheiseRestaurantProductionText;
    public Image SushiFrancheiseRestaurantFill;
    public Button SushiFrancheiseRestaurantButton;
    public Text SushiFrancheiseRestaurantTimerText;

    public Text PlaneRestaurantTitleText;
    public Text PlaneRestaurantCostText;
    public Text PlaneRestaurantProductionText;
    public Image PlaneRestaurantFill;
    public Button PlaneRestaurantButton;
    public Text PlaneRestaurantTimerText;

    public GameObject ShopPanelImage;
    public GameObject ManagersPanel;
    public GameObject UpgradesButton;
    public GameObject UpgradesPanel;
    public GameObject AchivementButton;
    public GameObject AchivementPanel;

    public Text HotdogCounterUpgradesTittleText;
    public Text HotdogCounterUpgradesCostText;
    public GameObject UpgradesHotdogCounter1;
    public Button UpgradesHotdogCounterButton1;

    public Text HotdogCarUpgradesTittleText;
    public Text HotdogCarUpgradesCostText;
    public GameObject UpgradesHotdogCar1;
    public Button UpgradesHotdogCarButton1;

    public Text HotdogBigRestaurantUpgradesTittleText;
    public Text HotdogBigRestaurantUpgradesCostText;
    public GameObject UpgradesHotdogBigRestaurant1;
    public Button UpgradesHotdogBigRestaurantButton1;

    public Text HotdogRestaurantUpgradesTittleText;
    public Text HotdogRestaurantUpgradesCostText;
    public GameObject UpgradesHotdogRestaurant1;
    public Button UpgradesHotdogRestaurantButton1;

    public Text HotdogFrancheiseRestaurantUpgradesTittleText;
    public Text HotdogFrancheiseRestaurantUpgradesCostText;
    public GameObject UpgradesHotdogFrancheiseRestaurant1;
    public Button UpgradesHotdogFrancheiseRestaurantButton1;

    public Text PizzaRestaurantUpgradesTittleText;
    public Text PizzaRestaurantUpgradesCostText;
    public GameObject UpgradesPizzaRestaurant1;
    public Button UpgradesPizzaRestaurantButton1;

    public Text PizzaFrancheiseRestaurantUpgradesTittleText;
    public Text PizzaFrancheiseRestaurantUpgradesCostText;
    public GameObject UpgradesPizzaFrancheiseRestaurant1;
    public Button UpgradesPizzaFrancheiseRestaurantButton1;

    public Text BurgerRestaurantUpgradesTittleText;
    public Text BurgerRestaurantUpgradesCostText;
    public GameObject UpgradesBurgerRestaurant1;
    public Button UpgradesBurgerRestaurantButton1;

    public Text BurgerFrancheiseRestaurantUpgradesTittleText;
    public Text BurgerFrancheiseRestaurantUpgradesCostText;
    public GameObject UpgradesBurgerFrancheiseRestaurant1;
    public Button UpgradesBurgerFrancheiseRestaurantButton1;

    public Text SushiRestaurantUpgradesTittleText;
    public Text SushiRestaurantUpgradesCostText;
    public GameObject UpgradesSushiRestaurant1;
    public Button UpgradesSushiRestaurantButton1;

    public Text SushiFrancheiseRestaurantUpgradesTittleText;
    public Text SushiFrancheiseRestaurantUpgradesCostText;
    public GameObject UpgradesSushiFrancheiseRestaurant1;
    public Button UpgradesSushiFrancheiseRestaurantButton1;

    public Text PlaneRestaurantUpgradesTittleText;
    public Text PlaneRestaurantUpgradesCostText;
    public GameObject UpgradesPlaneRestaurant1;
    public Button UpgradesPlaneRestaurantButton1;

    public Text HotdogCounterUpgradesTittleText2;
    public Text HotdogCounterUpgradesCostText2;
    public GameObject UpgradesHotdogCounter2;
    public Button UpgradesHotdogCounterButton2;

    public Text HotdogCarUpgradesTittleText2;
    public Text HotdogCarUpgradesCostText2;
    public GameObject UpgradesHotdogCar2;
    public Button UpgradesHotdogCarButton2;

    public Text HotdogBigRestaurantUpgradesTittleText2;
    public Text HotdogBigRestaurantUpgradesCostText2;
    public GameObject UpgradesHotdogBigRestaurant2;
    public Button UpgradesHotdogBigRestaurantButton2;

    public Text HotdogRestaurantUpgradesTittleText2;
    public Text HotdogRestaurantUpgradesCostText2;
    public GameObject UpgradesHotdogRestaurant2;
    public Button UpgradesHotdogRestaurantButton2;

    public Text HotdogFrancheiseRestaurantUpgradesTittleText2;
    public Text HotdogFrancheiseRestaurantUpgradesCostText2;
    public GameObject UpgradesHotdogFrancheiseRestaurant2;
    public Button UpgradesHotdogFrancheiseRestaurantButton2;

    public Text PizzaRestaurantUpgradesTittleText2;
    public Text PizzaRestaurantUpgradesCostText2;
    public GameObject UpgradesPizzaRestaurant2;
    public Button UpgradesPizzaRestaurantButton2;

    public Text PizzaFrancheiseRestaurantUpgradesTittleText2;
    public Text PizzaFrancheiseRestaurantUpgradesCostText2;
    public GameObject UpgradesPizzaFrancheiseRestaurant2;
    public Button UpgradesPizzaFrancheiseRestaurantButton2;

    public Text BurgerRestaurantUpgradesTittleText2;
    public Text BurgerRestaurantUpgradesCostText2;
    public GameObject UpgradesBurgerRestaurant2;
    public Button UpgradesBurgerRestaurantButton2;

    public Text BurgerFrancheiseRestaurantUpgradesTittleText2;
    public Text BurgerFrancheiseRestaurantUpgradesCostText2;
    public GameObject UpgradesBurgerFrancheiseRestaurant2;
    public Button UpgradesBurgerFrancheiseRestaurantButton2;

    public Text SushiRestaurantUpgradesTittleText2;
    public Text SushiRestaurantUpgradesCostText2;
    public GameObject UpgradesSushiRestaurant2;
    public Button UpgradesSushiRestaurantButton2;

    public Text SushiFrancheiseRestaurantUpgradesTittleText2;
    public Text SushiFrancheiseRestaurantUpgradesCostText2;
    public GameObject UpgradesSushiFrancheiseRestaurant2;
    public Button UpgradesSushiFrancheiseRestaurantButton2;

    public Text PlaneRestaurantUpgradesTittleText2;
    public Text PlaneRestaurantUpgradesCostText2;
    public GameObject UpgradesPlaneRestaurant2;
    public Button UpgradesPlaneRestaurantButton2;

    public Text HotdogCounterUpgradesTittleText3;
    public Text HotdogCounterUpgradesCostText3;
    public GameObject UpgradesHotdogCounter3;
    public Button UpgradesHotdogCounterButton3;

    public Text HotdogCarUpgradesTittleText3;
    public Text HotdogCarUpgradesCostText3;
    public GameObject UpgradesHotdogCar3;
    public Button UpgradesHotdogCarButton3;

    public Text HotdogBigRestaurantUpgradesTittleText3;
    public Text HotdogBigRestaurantUpgradesCostText3;
    public GameObject UpgradesHotdogBigRestaurant3;
    public Button UpgradesHotdogBigRestaurantButton3;

    public Text HotdogRestaurantUpgradesTittleText3;
    public Text HotdogRestaurantUpgradesCostText3;
    public GameObject UpgradesHotdogRestaurant3;
    public Button UpgradesHotdogRestaurantButton3;

    public Text HotdogFrancheiseRestaurantUpgradesTittleText3;
    public Text HotdogFrancheiseRestaurantUpgradesCostText3;
    public GameObject UpgradesHotdogFrancheiseRestaurant3;
    public Button UpgradesHotdogFrancheiseRestaurantButton3;

    public Text PizzaRestaurantUpgradesTittleText3;
    public Text PizzaRestaurantUpgradesCostText3;
    public GameObject UpgradesPizzaRestaurant3;
    public Button UpgradesPizzaRestaurantButton3;

    public Text PizzaFrancheiseRestaurantUpgradesTittleText3;
    public Text PizzaFrancheiseRestaurantUpgradesCostText3;
    public GameObject UpgradesPizzaFrancheiseRestaurant3;
    public Button UpgradesPizzaFrancheiseRestaurantButton3;

    public Text BurgerRestaurantUpgradesTittleText3;
    public Text BurgerRestaurantUpgradesCostText3;
    public GameObject UpgradesBurgerRestaurant3;
    public Button UpgradesBurgerRestaurantButton3;

    public Text BurgerFrancheiseRestaurantUpgradesTittleText3;
    public Text BurgerFrancheiseRestaurantUpgradesCostText3;
    public GameObject UpgradesBurgerFrancheiseRestaurant3;
    public Button UpgradesBurgerFrancheiseRestaurantButton3;

    public Text SushiRestaurantUpgradesTittleText3;
    public Text SushiRestaurantUpgradesCostText3;
    public GameObject UpgradesSushiRestaurant3;
    public Button UpgradesSushiRestaurantButton3;

    public Text SushiFrancheiseRestaurantUpgradesTittleText3;
    public Text SushiFrancheiseRestaurantUpgradesCostText3;
    public GameObject UpgradesSushiFrancheiseRestaurant3;
    public Button UpgradesSushiFrancheiseRestaurantButton3;

    public Text PlaneRestaurantUpgradesTittleText3;
    public Text PlaneRestaurantUpgradesCostText3;
    public GameObject UpgradesPlaneRestaurant3;
    public Button UpgradesPlaneRestaurantButton3;

    public Text HotdogCounterUpgradesTittleText4;
    public Text HotdogCounterUpgradesCostText4;
    public GameObject UpgradesHotdogCounter4;
    public Button UpgradesHotdogCounterButton4;

    public Text HotdogCarUpgradesTittleText4;
    public Text HotdogCarUpgradesCostText4;
    public GameObject UpgradesHotdogCar4;
    public Button UpgradesHotdogCarButton4;

    public Text HotdogBigRestaurantUpgradesTittleText4;
    public Text HotdogBigRestaurantUpgradesCostText4;
    public GameObject UpgradesHotdogBigRestaurant4;
    public Button UpgradesHotdogBigRestaurantButton4;

    public Text HotdogRestaurantUpgradesTittleText4;
    public Text HotdogRestaurantUpgradesCostText4;
    public GameObject UpgradesHotdogRestaurant4;
    public Button UpgradesHotdogRestaurantButton4;

    public Text HotdogFrancheiseRestaurantUpgradesTittleText4;
    public Text HotdogFrancheiseRestaurantUpgradesCostText4;
    public GameObject UpgradesHotdogFrancheiseRestaurant4;
    public Button UpgradesHotdogFrancheiseRestaurantButton4;

    public Text PizzaRestaurantUpgradesTittleText4;
    public Text PizzaRestaurantUpgradesCostText4;
    public GameObject UpgradesPizzaRestaurant4;
    public Button UpgradesPizzaRestaurantButton4;

    public Text PizzaFrancheiseRestaurantUpgradesTittleText4;
    public Text PizzaFrancheiseRestaurantUpgradesCostText4;
    public GameObject UpgradesPizzaFrancheiseRestaurant4;
    public Button UpgradesPizzaFrancheiseRestaurantButton4;

    public Text BurgerRestaurantUpgradesTittleText4;
    public Text BurgerRestaurantUpgradesCostText4;
    public GameObject UpgradesBurgerRestaurant4;
    public Button UpgradesBurgerRestaurantButton4;

    public Text BurgerFrancheiseRestaurantUpgradesTittleText4;
    public Text BurgerFrancheiseRestaurantUpgradesCostText4;
    public GameObject UpgradesBurgerFrancheiseRestaurant4;
    public Button UpgradesBurgerFrancheiseRestaurantButton4;

    public Text SushiRestaurantUpgradesTittleText4;
    public Text SushiRestaurantUpgradesCostText4;
    public GameObject UpgradesSushiRestaurant4;
    public Button UpgradesSushiRestaurantButton4;

    public Text SushiFrancheiseRestaurantUpgradesTittleText4;
    public Text SushiFrancheiseRestaurantUpgradesCostText4;
    public GameObject UpgradesSushiFrancheiseRestaurant4;
    public Button UpgradesSushiFrancheiseRestaurantButton4;

    public Text PlaneRestaurantUpgradesTittleText4;
    public Text PlaneRestaurantUpgradesCostText4;
    public GameObject UpgradesPlaneRestaurant4;
    public Button UpgradesPlaneRestaurantButton4;

    public Text HotdogCounterManagerTittleText;
    public Text HotdogCounterManagerCostText;
    public GameObject HotdogCounterManager;
    public Button HotdogCounterManagerButton1;

    public Text HotdogCarManagerTittleText;
    public Text HotdogCarManagerCostText;
    public GameObject HotdogCarManager;
    public Button HotdogCarManagerButton1;

    public Text HotdogBigRestaurantManagerTittleText;
    public Text HotdogBigRestaurantManagerCostText;
    public GameObject HotdogBigRestaurantManager;
    public Button HotdogBigRestaurantManagerButton1;

    public Text HotdogRestaurantManagerTittleText;
    public Text HotdogRestaurantManagerCostText;
    public GameObject HotdogRestaurantManager;
    public Button HotdogRestaurantManagerButton1;

    public Text HotdogFrancheiseRestaurantManagerTittleText;
    public Text HotdogFrancheiseRestaurantManagerCostText;
    public GameObject HotdogFrancheiseRestaurantManager;
    public Button HotdogFrancheiseRestaurantManagerButton1;

    public Text PizzaRestaurantManagerTittleText;
    public Text PizzaRestaurantManagerCostText;
    public GameObject PizzaRestaurantManager;
    public Button PizzaRestaurantManagerButton1;

    public Text PizzaFrancheiseRestaurantManagerTittleText;
    public Text PizzaFrancheiseRestaurantManagerCostText;
    public GameObject PizzaFrancheiseRestaurantManager;
    public Button PizzaFrancheiseRestaurantManagerButton1;

    public Text BurgerRestaurantManagerTittleText;
    public Text BurgerRestaurantManagerCostText;
    public GameObject BurgerRestaurantManager;
    public Button BurgerRestaurantManagerButton1;

    public Text BurgerFrancheiseRestaurantManagerTittleText;
    public Text BurgerFrancheiseRestaurantManagerCostText;
    public GameObject BurgerFrancheiseRestaurantManager;
    public Button BurgerFrancheiseRestaurantManagerButton1;

    public Text SushiRestaurantManagerTittleText;
    public Text SushiRestaurantManagerCostText;
    public GameObject SushiRestaurantManager;
    public Button SushiRestaurantManagerButton1;

    public Text SushiFrancheiseRestaurantManagerTittleText;
    public Text SushiFrancheiseRestaurantManagerCostText;
    public GameObject SushiFrancheiseRestaurantManager;
    public Button SushiFrancheiseRestaurantManagerButton1;

    public Text PlaneRestaurantManagerTittleText;
    public Text PlaneRestaurantManagerCostText;
    public GameObject PlaneRestaurantManager;
    public Button PlaneRestaurantManagerButton1;


    public void RunHotdogs()
    {
        RunHotdog(1, "Hotdog Counter", HotdogCounterTitleText, HotdogCounterCostText, HotdogCounterProductionText, HotdogCounterFill, data.HotdogCounterLevel, data.HotdogCounterCost, data.HotdogCounterPower, data.HotdogCounterMult, ref data.HotdogCounterTimer, data.HotdogCounterTimeCap, data.HotdogCounterAuto,HotdogCounterTimerText);
        RunHotdog(2, "Hotdog Car", HotdogCarTitleText, HotdogCarCostText, HotdogCarProductionText, HotdogCarFill, data.HotdogCarLevel, data.HotdogCarCost, data.HotdogCarPower, data.HotdogCarMult, ref data.HotdogCarTimer, data.HotdogCarTimeCap, data.HotdogCarAuto,HotdogCarTimerText);
        RunHotdog(3, "Hotdog Big Restaurant", HotdogBigRestaurantTitleText, HotdogBigRestaurantCostText, HotdogBigRestaurantProductionText, HotdogBigRestaurantFill, data.HotdogBigRestaurantLevel, data.HotdogBigRestaurantCost, data.HotdogBigRestaurantPower, data.HotdogBigRestaurantMult, ref data.HotdogBigRestaurantTimer, data.HotdogBigRestaurantTimeCap, data.HotdogBigRestaurantAuto,HotdogBigRestaurantTimerText);
        RunHotdog(4, "Hotdog Restaurant", HotdogRestaurantTitleText, HotdogRestaurantCostText, HotdogRestaurantProductionText, HotdogRestaurantFill, data.HotdogRestaurantLevel, data.HotdogRestaurantCost, data.HotdogRestaurantPower, data.HotdogRestaurantMult, ref data.HotdogRestaurantTimer, data.HotdogRestaurantTimeCap, data.HotdogRestaurantAuto,HotdogRestaurantTimerText);
        RunHotdog(5, "Hotdog Francheise", HotdogFrancheiseRestaurantTitleText, HotdogFrancheiseRestaurantCostText, HotdogFrancheiseRestaurantProductionText, HotdogFrancheiseRestaurantFill, data.HotdogFrancheiseRestaurantLevel, data.HotdogFrancheiseRestaurantCost, data.HotdogFrancheiseRestaurantPower, data.HotdogFrancheiseRestaurantMult, ref data.HotdogFrancheiseRestaurantTimer, data.HotdogFrancheiseRestaurantTimeCap, data.HotdogFrancheiseRestaurantAuto,HotdogFrancheiseRestaurantTimerText);
        RunHotdog(6, "Pizza Restaurant", PizzaRestaurantTitleText, PizzaRestaurantCostText, PizzaRestaurantProductionText, PizzaRestaurantFill, data.PizzaRestaurantLevel, data.PizzaRestaurantCost, data.PizzaRestaurantPower, data.PizzaRestaurantMult, ref data.PizzaRestaurantTimer, data.PizzaRestaurantTimeCap, data.PizzaRestaurantAuto,PizzaRestaurantTimerText);
        RunHotdog(7, "Pizza Francheise", PizzaFrancheiseRestaurantTitleText, PizzaFrancheiseRestaurantCostText, PizzaFrancheiseRestaurantProductionText, PizzaFrancheiseRestaurantFill, data.PizzaFrancheiseRestaurantLevel, data.PizzaFrancheiseRestaurantCost, data.PizzaFrancheiseRestaurantPower, data.PizzaFrancheiseRestaurantMult, ref data.PizzaFrancheiseRestaurantTimer, data.PizzaFrancheiseRestaurantTimeCap, data.PizzaFrancheiseRestaurantAuto,PizzaFrancheiseRestaurantTimerText);
        RunHotdog(8, "Burger Restaurant", BurgerRestaurantTitleText, BurgerRestaurantCostText, BurgerRestaurantProductionText, BurgerRestaurantFill, data.BurgerRestaurantLevel, data.BurgerRestaurantCost, data.BurgerRestaurantPower, data.BurgerRestaurantMult, ref data.BurgerRestaurantTimer, data.BurgerRestaurantTimeCap, data.BurgerRestaurantAuto,BurgerRestaurantTimerText);
        RunHotdog(9, "Burger Francheise", BurgerFrancheiseRestaurantTitleText, BurgerFrancheiseRestaurantCostText, BurgerFrancheiseRestaurantProductionText, BurgerFrancheiseRestaurantFill, data.BurgerFrancheiseRestaurantLevel, data.BurgerFrancheiseRestaurantCost, data.BurgerFrancheiseRestaurantPower, data.BurgerFrancheiseRestaurantMult, ref data.BurgerFrancheiseRestaurantTimer, data.BurgerFrancheiseRestaurantTimeCap, data.BurgerFrancheiseRestaurantAuto,BurgerFrancheiseRestaurantTimerText);
        RunHotdog(10, "Sushi Restaurant", SushiRestaurantTitleText, SushiRestaurantCostText, SushiRestaurantProductionText, SushiRestaurantFill, data.SushiRestaurantLevel, data.SushiRestaurantCost, data.SushiRestaurantPower, data.SushiRestaurantMult, ref data.SushiRestaurantTimer, data.SushiRestaurantTimeCap, data.SushiRestaurantAuto,SushiRestaurantTimerText);
        RunHotdog(11, "Sushi Francheise", SushiFrancheiseRestaurantTitleText, SushiFrancheiseRestaurantCostText, SushiFrancheiseRestaurantProductionText, SushiFrancheiseRestaurantFill, data.SushiFrancheiseRestaurantLevel, data.SushiFrancheiseRestaurantCost, data.SushiFrancheiseRestaurantPower, data.SushiFrancheiseRestaurantMult, ref data.SushiFrancheiseRestaurantTimer, data.SushiFrancheiseRestaurantTimeCap, data.SushiFrancheiseRestaurantAuto,SushiFrancheiseRestaurantTimerText);
        RunHotdog(12, "Plane Restaurant", PlaneRestaurantTitleText, PlaneRestaurantCostText, PlaneRestaurantProductionText, PlaneRestaurantFill, data.PlaneRestaurantLevel, data.PlaneRestaurantCost, data.PlaneRestaurantPower, data.PlaneRestaurantMult, ref data.PlaneRestaurantTimer, data.PlaneRestaurantTimeCap, data.PlaneRestaurantAuto,PlaneRestaurantTimerText);

    }
    public void RunUpgrades()
    {
        RunUpgrade(1, "Increase your Hotdog Counter Profit %50 with Ketchup", HotdogCounterUpgradesTittleText, HotdogCounterUpgradesCostText, UpgradesHotdogCounter1, data.UpgradesHotdogCounterCost, data.UpgradesHotdogCounterLevel1);
        RunUpgrade(2, "Increase your Hotdog Car Profit %50 with Mustard", HotdogCarUpgradesTittleText, HotdogCarUpgradesCostText, UpgradesHotdogCar1, data.UpgradesHotdogCarCost, data.UpgradesHotdogCarLevel1);
        RunUpgrade(3, "Increase your Hotdog Big Restaurant Profit %50 with Barbecue Sauce", HotdogBigRestaurantUpgradesTittleText, HotdogBigRestaurantUpgradesCostText, UpgradesHotdogBigRestaurant1, data.UpgradesHotdogBigRestaurantCost, data.UpgradesHotdogBigRestaurantLevel1);
        RunUpgrade(4, "Increase your Hotdog Restaurant Profit %50 with Cheddar Sauce", HotdogRestaurantUpgradesTittleText, HotdogRestaurantUpgradesCostText, UpgradesHotdogRestaurant1, data.UpgradesHotdogRestaurantCost, data.UpgradesHotdogRestaurantLevel1);
        RunUpgrade(5, "Increase your Hotdog Francheise Restaurant Profit %50 with Hotchill Sauce", HotdogFrancheiseRestaurantUpgradesTittleText, HotdogFrancheiseRestaurantUpgradesCostText, UpgradesHotdogFrancheiseRestaurant1, data.UpgradesHotdogFrancheiseRestaurantCost, data.UpgradesHotdogFrancheiseRestaurantLevel1);
        RunUpgrade(6, "Increase your Pizza Restaurant Profit %50 with Mayoneise", PizzaRestaurantUpgradesTittleText, PizzaRestaurantUpgradesCostText, UpgradesPizzaRestaurant1, data.UpgradesPizzaRestaurantCost, data.UpgradesPizzaRestaurantLevel1);
        RunUpgrade(7, "Increase your Pizza Franhceise Restaurant Profit %50 with Coke", PizzaFrancheiseRestaurantUpgradesTittleText, PizzaFrancheiseRestaurantUpgradesCostText, UpgradesPizzaFrancheiseRestaurant1, data.UpgradesPizzaFrancheiseRestaurantCost, data.UpgradesPizzaFrancheiseRestaurantLevel1);
        RunUpgrade(8, "Increase your Burger Restaurant Profit %50 with Pineapple Juice", BurgerRestaurantUpgradesTittleText, BurgerRestaurantUpgradesCostText, UpgradesBurgerRestaurant1, data.UpgradesBurgerRestaurantCost, data.UpgradesBurgerRestaurantLevel1);
        RunUpgrade(9, "Increase your Burger Francheise Restaurant Profit %50 with Extra Meatball", BurgerFrancheiseRestaurantUpgradesTittleText, BurgerFrancheiseRestaurantUpgradesCostText, UpgradesBurgerFrancheiseRestaurant1, data.UpgradesBurgerFrancheiseRestaurantCost, data.UpgradesBurgerFrancheiseRestaurantLevel1);
        RunUpgrade(10, "Increase your Sushi Restaurant Profit %50 with Extra Tomato", SushiRestaurantUpgradesTittleText, SushiRestaurantUpgradesCostText, UpgradesSushiRestaurant1, data.UpgradesSushiRestaurantCost, data.UpgradesSushiRestaurantLevel1);
        RunUpgrade(11, "Increase your Sushi Francheise Restaurant Profit %50 with Extra Onion", SushiFrancheiseRestaurantUpgradesTittleText, SushiFrancheiseRestaurantUpgradesCostText, UpgradesSushiFrancheiseRestaurant1, data.UpgradesSushiFrancheiseRestaurantCost, data.UpgradesSushiFrancheiseRestaurantLevel1);
        RunUpgrade(12, "Increase your Plane Restaurant Profit %50 with Extra Pickle", PlaneRestaurantUpgradesTittleText, PlaneRestaurantUpgradesCostText, UpgradesPlaneRestaurant1, data.UpgradesPlaneRestaurantCost, data.UpgradesPlaneRestaurantLevel1);

    }
    public void RunUpgrades2()
    {
        RunUpgrade(1, "Increase your Hotdog Counter Profit %75 with Extra Garlic", HotdogCounterUpgradesTittleText2, HotdogCounterUpgradesCostText2, UpgradesHotdogCounter2, data.UpgradesHotdogCounterCost2, data.UpgradesHotdogCounterLevel2);
        RunUpgrade(2, "Increase your Hotdog Car Profit %75 with Fanta", HotdogCarUpgradesTittleText2, HotdogCarUpgradesCostText2, UpgradesHotdogCar2, data.UpgradesHotdogCarCost2, data.UpgradesHotdogCarLevel2);
        RunUpgrade(3, "Increase your Hotdog Big Restaurant Profit %75 with Soda", HotdogBigRestaurantUpgradesTittleText2, HotdogBigRestaurantUpgradesCostText2, UpgradesHotdogBigRestaurant2, data.UpgradesHotdogBigRestaurantCost2, data.UpgradesHotdogBigRestaurantLevel2);
        RunUpgrade(4, "Increase your Hotdog Restaurant Profit %75 With Extra Salam", HotdogRestaurantUpgradesTittleText2, HotdogRestaurantUpgradesCostText2, UpgradesHotdogRestaurant2, data.UpgradesHotdogRestaurantCost2, data.UpgradesHotdogRestaurantLevel2);
        RunUpgrade(5, "Increase your Hotdog Francheise Restaurant Profit %75 with Icecream", HotdogFrancheiseRestaurantUpgradesTittleText2, HotdogFrancheiseRestaurantUpgradesCostText2, UpgradesHotdogFrancheiseRestaurant2, data.UpgradesHotdogFrancheiseRestaurantCost2, data.UpgradesHotdogFrancheiseRestaurantLevel2);
        RunUpgrade(6, "Increase your Pizza Restaurant Profit %75 with Energy Drink", PizzaRestaurantUpgradesTittleText2, PizzaRestaurantUpgradesCostText2, UpgradesPizzaRestaurant2, data.UpgradesPizzaRestaurantCost2, data.UpgradesPizzaRestaurantLevel2);
        RunUpgrade(7, "Increase your Pizza Franhceise Restaurant Profit %75 with Soda", PizzaFrancheiseRestaurantUpgradesTittleText2, PizzaFrancheiseRestaurantUpgradesCostText2, UpgradesPizzaFrancheiseRestaurant2, data.UpgradesPizzaFrancheiseRestaurantCost2, data.UpgradesPizzaFrancheiseRestaurantLevel2);
        RunUpgrade(8, "Increase your Burger Restaurant Profit %75 with Donut", BurgerRestaurantUpgradesTittleText2, BurgerRestaurantUpgradesCostText2, UpgradesBurgerRestaurant2, data.UpgradesBurgerRestaurantCost2, data.UpgradesBurgerRestaurantLevel2);
        RunUpgrade(9, "Increase your Burger Francheise Restaurant Profit %75 with Pickles", BurgerFrancheiseRestaurantUpgradesTittleText2, BurgerFrancheiseRestaurantUpgradesCostText2, UpgradesBurgerFrancheiseRestaurant2, data.UpgradesBurgerFrancheiseRestaurantCost2, data.UpgradesBurgerFrancheiseRestaurantLevel2);
        RunUpgrade(10, "Increase your Sushi Restaurant Profit %75 with Cesar Salad", SushiRestaurantUpgradesTittleText2, SushiRestaurantUpgradesCostText2, UpgradesSushiRestaurant2, data.UpgradesSushiRestaurantCost2, data.UpgradesSushiRestaurantLevel2);
        RunUpgrade(11, "Increase your Sushi Francheise Restaurant Profit %75 with Tuna", SushiFrancheiseRestaurantUpgradesTittleText2, SushiFrancheiseRestaurantUpgradesCostText2, UpgradesSushiFrancheiseRestaurant2, data.UpgradesSushiFrancheiseRestaurantCost2, data.UpgradesSushiFrancheiseRestaurantLevel2);
        RunUpgrade(12, "Increase your Plane Restaurant Profit %75 with Champagne", PlaneRestaurantUpgradesTittleText2, PlaneRestaurantUpgradesCostText2, UpgradesPlaneRestaurant2, data.UpgradesPlaneRestaurantCost2, data.UpgradesPlaneRestaurantLevel2);

    }
    public void RunUpgrades3()
    {
        RunUpgrade(1, "Increase your Hotdog Counter Profit %100 with IceCream", HotdogCounterUpgradesTittleText3, HotdogCounterUpgradesCostText3, UpgradesHotdogCounter3, data.UpgradesHotdogCounterCost3, data.UpgradesHotdogCounterLevel3);
        RunUpgrade(2, "Increase your Hotdog Car Profit %100 with Extra Meat", HotdogCarUpgradesTittleText3, HotdogCarUpgradesCostText3, UpgradesHotdogCar3, data.UpgradesHotdogCarCost3, data.UpgradesHotdogCarLevel3);
        RunUpgrade(3, "Increase your Hotdog Big Restaurant Profit %100 with Donut", HotdogBigRestaurantUpgradesTittleText3, HotdogBigRestaurantUpgradesCostText3, UpgradesHotdogBigRestaurant3, data.UpgradesHotdogBigRestaurantCost3, data.UpgradesHotdogBigRestaurantLevel3);
        RunUpgrade(4, "Increase your Hotdog Restaurant Profit %100 with Olive", HotdogRestaurantUpgradesTittleText3, HotdogRestaurantUpgradesCostText3, UpgradesHotdogRestaurant3, data.UpgradesHotdogRestaurantCost3, data.UpgradesHotdogRestaurantLevel3);
        RunUpgrade(5, "Increase your Hotdog Francheise Restaurant Profit %100 with Icecream", HotdogFrancheiseRestaurantUpgradesTittleText3, HotdogFrancheiseRestaurantUpgradesCostText3, UpgradesHotdogFrancheiseRestaurant3, data.UpgradesHotdogFrancheiseRestaurantCost3, data.UpgradesHotdogFrancheiseRestaurantLevel3);
        RunUpgrade(6, "Increase your Pizza Restaurant Profit %100 with Beer", PizzaRestaurantUpgradesTittleText3, PizzaRestaurantUpgradesCostText3, UpgradesPizzaRestaurant3, data.UpgradesPizzaRestaurantCost3, data.UpgradesPizzaRestaurantLevel3);
        RunUpgrade(7, "Increase your Pizza Franhceise Restaurant Profit %100 with Salad", PizzaFrancheiseRestaurantUpgradesTittleText3, PizzaFrancheiseRestaurantUpgradesCostText3, UpgradesPizzaFrancheiseRestaurant3, data.UpgradesPizzaFrancheiseRestaurantCost3, data.UpgradesPizzaFrancheiseRestaurantLevel3);
        RunUpgrade(8, "Increase your Burger Restaurant Profit %100 with Wine", BurgerRestaurantUpgradesTittleText3, BurgerRestaurantUpgradesCostText3, UpgradesBurgerRestaurant3, data.UpgradesBurgerRestaurantCost3, data.UpgradesBurgerRestaurantLevel3);
        RunUpgrade(9, "Increase your Burger Francheise Restaurant Profit %100 with Extra Lettuce", BurgerFrancheiseRestaurantUpgradesTittleText3, BurgerFrancheiseRestaurantUpgradesCostText3, UpgradesBurgerFrancheiseRestaurant3, data.UpgradesBurgerFrancheiseRestaurantCost3, data.UpgradesBurgerFrancheiseRestaurantLevel3);
        RunUpgrade(10, "Increase your Sushi Restaurant Profit %100 with Soy Sauce", SushiRestaurantUpgradesTittleText3, SushiRestaurantUpgradesCostText3, UpgradesSushiRestaurant3, data.UpgradesSushiRestaurantCost3, data.UpgradesSushiRestaurantLevel3);
        RunUpgrade(11, "Increase your Sushi Francheise Restaurant Profit %100 with Vegetable Soup", SushiFrancheiseRestaurantUpgradesTittleText3, SushiFrancheiseRestaurantUpgradesCostText3, UpgradesSushiFrancheiseRestaurant3, data.UpgradesSushiFrancheiseRestaurantCost3, data.UpgradesSushiFrancheiseRestaurantLevel3);
        RunUpgrade(12, "Increase your Plane Restaurant Profit %100 with Cognac", PlaneRestaurantUpgradesTittleText3, PlaneRestaurantUpgradesCostText3, UpgradesPlaneRestaurant3, data.UpgradesPlaneRestaurantCost3, data.UpgradesPlaneRestaurantLevel3);

    }
    public void RunUpgrades4()
    {
        RunUpgrade(1, "Increase your Hotdog Counter Profit %150 with Donut", HotdogCounterUpgradesTittleText4, HotdogCounterUpgradesCostText4, UpgradesHotdogCounter4, data.UpgradesHotdogCounterCost4, data.UpgradesHotdogCounterLevel4);
        RunUpgrade(2, "Increase your Hotdog Car Profit %150 with Fish Salad", HotdogCarUpgradesTittleText4, HotdogCarUpgradesCostText4, UpgradesHotdogCar4, data.UpgradesHotdogCarCost4, data.UpgradesHotdogCarLevel4);
        RunUpgrade(3, "Increase your Hotdog Big Restaurant Profit %150 with Milk", HotdogBigRestaurantUpgradesTittleText4, HotdogBigRestaurantUpgradesCostText4, UpgradesHotdogBigRestaurant4, data.UpgradesHotdogBigRestaurantCost4, data.UpgradesHotdogBigRestaurantLevel4);
        RunUpgrade(4, "Increase your Hotdog Restaurant Profit %150 with Pineapple Juice", HotdogRestaurantUpgradesTittleText4, HotdogRestaurantUpgradesCostText4, UpgradesHotdogRestaurant4, data.UpgradesHotdogRestaurantCost4, data.UpgradesHotdogRestaurantLevel4);
        RunUpgrade(5, "Increase your Hotdog Francheise Restaurant Profit %150 with Soda", HotdogFrancheiseRestaurantUpgradesTittleText4, HotdogFrancheiseRestaurantUpgradesCostText4, UpgradesHotdogFrancheiseRestaurant4, data.UpgradesHotdogFrancheiseRestaurantCost4, data.UpgradesHotdogFrancheiseRestaurantLevel4);
        RunUpgrade(6, "Increase your Pizza Restaurant Profit %150 with Churchill", PizzaRestaurantUpgradesTittleText4, PizzaRestaurantUpgradesCostText4, UpgradesPizzaRestaurant4, data.UpgradesPizzaRestaurantCost4, data.UpgradesPizzaRestaurantLevel4);
        RunUpgrade(7, "Increase your Pizza Franhceise Restaurant Profit %150 with London Scotch", PizzaFrancheiseRestaurantUpgradesTittleText4, PizzaFrancheiseRestaurantUpgradesCostText4, UpgradesPizzaFrancheiseRestaurant4, data.UpgradesPizzaFrancheiseRestaurantCost4, data.UpgradesPizzaFrancheiseRestaurantLevel4);
        RunUpgrade(8, "Increase your Burger Restaurant Profit %150 with Tea", BurgerRestaurantUpgradesTittleText4, BurgerRestaurantUpgradesCostText4, UpgradesBurgerRestaurant4, data.UpgradesBurgerRestaurantCost4, data.UpgradesBurgerRestaurantLevel4);
        RunUpgrade(9, "Increase your Burger Francheise Restaurant Profit %150 with Vodka", BurgerFrancheiseRestaurantUpgradesTittleText4, BurgerFrancheiseRestaurantUpgradesCostText4, UpgradesBurgerFrancheiseRestaurant4, data.UpgradesBurgerFrancheiseRestaurantCost4, data.UpgradesBurgerFrancheiseRestaurantLevel4);
        RunUpgrade(10, "Increase your Sushi Restaurant Profit %150 with Whiskey", SushiRestaurantUpgradesTittleText4, SushiRestaurantUpgradesCostText4, UpgradesSushiRestaurant4, data.UpgradesSushiRestaurantCost4, data.UpgradesSushiRestaurantLevel4);
        RunUpgrade(11, "Increase your Sushi Francheise Restaurant Profit %150 with Extra Wasabi", SushiFrancheiseRestaurantUpgradesTittleText4, SushiFrancheiseRestaurantUpgradesCostText4, UpgradesSushiFrancheiseRestaurant4, data.UpgradesSushiFrancheiseRestaurantCost4, data.UpgradesSushiFrancheiseRestaurantLevel4);
        RunUpgrade(12, "Increase your Plane Restaurant Profit %150  with Cognac", PlaneRestaurantUpgradesTittleText4, PlaneRestaurantUpgradesCostText4, UpgradesPlaneRestaurant4, data.UpgradesPlaneRestaurantCost4, data.UpgradesPlaneRestaurantLevel4);

    }
    public void RunUpgrade(int id, string title, Text TextT, Text CostT, GameObject GameO, double CostS, double level)
    {
        TextT.text = title;
        CostT.text = " $ " + Notation(CostS);
        if (level >= 1)
        {
            DestroyUpgrades(id);
            DestroyUpgrades2(id);
            DestroyUpgrades3(id);
            DestroyUpgrades4(id);
        }
    }
    public void RunManagers()
    {
        RunManager(1, "Hotdog Counter Manager", HotdogCounterManagerTittleText, HotdogCounterManagerCostText, HotdogCounterManager, data.HotdogCounterManagerCost, data.HotdogCounterManagerLevel1);
        RunManager(2, "Hotdog Car Manager", HotdogCarManagerTittleText, HotdogCarManagerCostText, HotdogCarManager, data.HotdogCarManagerCost, data.HotdogCarManagerLevel1);
        RunManager(3, "Hotdog Big Restaurant Manager", HotdogBigRestaurantManagerTittleText, HotdogBigRestaurantManagerCostText, HotdogBigRestaurantManager, data.HotdogBigRestaurantManagerCost, data.HotdogBigRestaurantManagerLevel1);
        RunManager(4, "Hotdog Restaurant Manager", HotdogRestaurantManagerTittleText, HotdogRestaurantManagerCostText, HotdogRestaurantManager, data.HotdogRestaurantManagerCost, data.HotdogRestaurantManagerLevel1);
        RunManager(5, "Hotdog Francheise Restaurant Manager", HotdogFrancheiseRestaurantManagerTittleText, HotdogFrancheiseRestaurantManagerCostText, HotdogFrancheiseRestaurantManager, data.HotdogFrancheiseRestaurantManagerCost, data.HotdogFrancheiseRestaurantManagerLevel1);
        RunManager(6, "Pizza Restaurant Manager", PizzaRestaurantManagerTittleText, PizzaRestaurantManagerCostText, PizzaRestaurantManager, data.PizzaRestaurantManagerCost, data.PizzaRestaurantManagerLevel1);
        RunManager(7, "Pizza Francheise Restaurant Manager", PizzaFrancheiseRestaurantManagerTittleText, PizzaFrancheiseRestaurantManagerCostText, PizzaFrancheiseRestaurantManager, data.PizzaFrancheiseRestaurantManagerCost, data.PizzaFrancheiseRestaurantManagerLevel1);
        RunManager(8, "Burger Restaurant Manager", BurgerRestaurantManagerTittleText, BurgerRestaurantManagerCostText, BurgerRestaurantManager, data.BurgerRestaurantManagerCost, data.BurgerRestaurantManagerLevel1);
        RunManager(9, "Burger Francheise Restaurant Manager", BurgerFrancheiseRestaurantManagerTittleText, BurgerFrancheiseRestaurantManagerCostText, BurgerFrancheiseRestaurantManager, data.BurgerFrancheiseRestaurantManagerCost, data.BurgerFrancheiseRestaurantManagerLevel1);
        RunManager(10, "Sushi Restaurant Manager", SushiRestaurantManagerTittleText, SushiRestaurantManagerCostText, SushiRestaurantManager, data.SushiRestaurantManagerCost, data.SushiRestaurantManagerLevel1);
        RunManager(11, "Sushi Francheise Restaurant Manager", SushiFrancheiseRestaurantManagerTittleText, SushiFrancheiseRestaurantManagerCostText, SushiFrancheiseRestaurantManager, data.SushiFrancheiseRestaurantManagerCost, data.SushiFrancheiseRestaurantManagerLevel1);
        RunManager(12, "Plane Restaurant Manager", PlaneRestaurantManagerTittleText, PlaneRestaurantManagerCostText, PlaneRestaurantManager, data.PlaneRestaurantManagerCost, data.PlaneRestaurantManagerLevel1);

    }
    public void RunManager(int id, string title, Text TextT, Text CostT, GameObject GameO, double CostS, double level)
    {
        TextT.text = title;
        CostT.text = " $ " + Notation(CostS);
        if (level >= 1)
        {
            DestroyManagers(id);
        }
    }
    public void RunHotdog(int id, string title, Text titleT, Text costT, Text prod, Image fill, double level, double cost, double power, double mult, ref float timer, float timeCap, bool auto,Text timerText)
    {

        titleT.text = title + " - " + level;
        costT.text = "\nCost :$ " + Notation(cost);
        prod.text = Notation(power) + " $";
        fill.fillAmount = timer / timeCap;
        timerText.text = Notations(timer) + " / " + Notations(timeCap);
        if (level != 0)
            if (timer <= timeCap)
            {
                timer += Time.deltaTime * (float)mult;
            }
            else if (auto)
                CollectHotdog(id);
            else
                timer = timeCap;


    }

    public void CollectHotdog(int id)
    {
        switch (id)
        {
            case 1:
                Collect(ref data.HotdogCounterTimer, data.HotdogCounterTimeCap, data.HotdogCounterPower);
                break;
            case 2:
                Collect(ref data.HotdogCarTimer, data.HotdogCarTimeCap, data.HotdogCarPower);
                break;
            case 3:
                Collect(ref data.HotdogBigRestaurantTimer, data.HotdogBigRestaurantTimeCap, data.HotdogBigRestaurantPower);
                break;
            case 4:
                Collect(ref data.HotdogRestaurantTimer, data.HotdogRestaurantTimeCap, data.HotdogRestaurantPower);
                break;
            case 5:
                Collect(ref data.HotdogFrancheiseRestaurantTimer, data.HotdogFrancheiseRestaurantTimeCap, data.HotdogFrancheiseRestaurantPower);
                break;
            case 6:
                Collect(ref data.PizzaRestaurantTimer, data.PizzaRestaurantTimeCap, data.PizzaRestaurantPower);
                break;
            case 7:
                Collect(ref data.PizzaFrancheiseRestaurantTimer, data.PizzaFrancheiseRestaurantTimeCap, data.PizzaFrancheiseRestaurantPower);
                break;
            case 8:
                Collect(ref data.BurgerRestaurantTimer, data.BurgerRestaurantTimeCap, data.BurgerRestaurantPower);
                break;
            case 9:
                Collect(ref data.BurgerFrancheiseRestaurantTimer, data.BurgerFrancheiseRestaurantTimeCap, data.BurgerFrancheiseRestaurantPower);
                break;
            case 10:
                Collect(ref data.SushiRestaurantTimer, data.SushiRestaurantTimeCap, data.SushiRestaurantPower);
                break;
            case 11:
                Collect(ref data.SushiFrancheiseRestaurantTimer, data.SushiFrancheiseRestaurantTimeCap, data.SushiFrancheiseRestaurantPower);
                break;
            case 12:
                Collect(ref data.PlaneRestaurantTimer, data.PlaneRestaurantTimeCap, data.PlaneRestaurantPower);
                break;

        }
    }
    public void Collect(ref float timer, float timeCap, double power)
    {
         if (timer >= timeCap)
        {
            data.dollar += power;
            timer = 0;
        }
       
  
    }

    #endregion
    public void BuyHotdogCounter(int id)
    {
        switch (id)
        {
            case 1:
                Buy(HotdogCounterButton, data.HotdogCounterCost, ref data.HotdogCounterLevel, ref data.HotdogCounterMult, ref data.HotdogCounterAuto);
                break;
            case 2:
                Buy(HotdogCarButton, data.HotdogCarCost, ref data.HotdogCarLevel, ref data.HotdogCarMult, ref data.HotdogCarAuto);
                break;
            case 3:
                Buy(HotdogBigRestaurantButton, data.HotdogBigRestaurantCost, ref data.HotdogBigRestaurantLevel, ref data.HotdogBigRestaurantMult, ref data.HotdogBigRestaurantAuto);
                break;
            case 4:
                Buy(HotdogRestaurantButton, data.HotdogRestaurantCost, ref data.HotdogRestaurantLevel, ref data.HotdogRestaurantMult, ref data.HotdogRestaurantAuto);
                break;
            case 5:
                Buy(HotdogFrancheiseRestaurantButton, data.HotdogFrancheiseRestaurantCost, ref data.HotdogFrancheiseRestaurantLevel, ref data.HotdogFrancheiseRestaurantMult, ref data.HotdogFrancheiseRestaurantAuto);
                break;
            case 6:
                Buy(PizzaRestaurantButton, data.PizzaRestaurantCost, ref data.PizzaRestaurantLevel, ref data.PizzaRestaurantMult, ref data.PizzaRestaurantAuto);
                break;
            case 7:
                Buy(PizzaFrancheiseRestaurantButton, data.PizzaFrancheiseRestaurantCost, ref data.PizzaFrancheiseRestaurantLevel, ref data.PizzaFrancheiseRestaurantMult, ref data.PizzaFrancheiseRestaurantAuto);
                break;
            case 8:
                Buy(BurgerRestaurantButton, data.BurgerRestaurantCost, ref data.BurgerRestaurantLevel, ref data.BurgerRestaurantMult, ref data.BurgerRestaurantAuto);
                break;
            case 9:
                Buy(BurgerFrancheiseRestaurantButton, data.BurgerFrancheiseRestaurantCost, ref data.BurgerFrancheiseRestaurantLevel, ref data.BurgerFrancheiseRestaurantMult, ref data.BurgerFrancheiseRestaurantAuto);
                break;
            case 10:
                Buy(SushiRestaurantButton, data.SushiRestaurantCost, ref data.SushiRestaurantLevel, ref data.SushiRestaurantMult, ref data.SushiRestaurantAuto);
                break;
            case 11:
                Buy(SushiFrancheiseRestaurantButton, data.SushiFrancheiseRestaurantCost, ref data.SushiFrancheiseRestaurantLevel, ref data.SushiFrancheiseRestaurantMult, ref data.SushiFrancheiseRestaurantAuto);
                break;
            case 12:
                Buy(PlaneRestaurantButton, data.PlaneRestaurantCost, ref data.PlaneRestaurantLevel, ref data.PlaneRestaurantMult, ref data.PlaneRestaurantAuto);
                break;
        }
    }

    public void Buy(Button ButBtns, double cost, ref double level, ref double mult, ref bool auto)
    {
        if (data.dollar >= cost)
        {
            data.dollar -= cost;
            level += 1;
            if (level == 10)
                mult *= 2;
            if (level == 25)
                mult *= 2;
            else if (level % 25 == 0)
                mult *= 2;
        }


    }
    public void ManagerHotdog(int id)
    {
        switch (id)
        {
            case 1:
                BuyManager(data.HotdogCounterManagerCost, ref data.HotdogCounterAuto, ref data.HotdogCounterManagerLevel1);
                break;
            case 2:
                BuyManager(data.HotdogCarManagerCost, ref data.HotdogCarAuto, ref data.HotdogCarManagerLevel1);
                break;
            case 3:
                BuyManager(data.HotdogBigRestaurantManagerCost, ref data.HotdogBigRestaurantAuto, ref data.HotdogBigRestaurantManagerLevel1);
                break;
            case 4:
                BuyManager(data.HotdogRestaurantManagerCost, ref data.HotdogRestaurantAuto, ref data.HotdogRestaurantManagerLevel1);
                break;
            case 5:
                BuyManager(data.HotdogFrancheiseRestaurantManagerCost, ref data.HotdogFrancheiseRestaurantAuto, ref data.HotdogFrancheiseRestaurantManagerLevel1);
                break;
            case 6:
                BuyManager(data.PizzaRestaurantManagerCost, ref data.PizzaRestaurantAuto, ref data.PizzaRestaurantManagerLevel1);
                break;
            case 7:
                BuyManager(data.PizzaFrancheiseRestaurantManagerCost, ref data.PizzaFrancheiseRestaurantAuto, ref data.PizzaFrancheiseRestaurantManagerLevel1);
                break;
            case 8:
                BuyManager(data.BurgerRestaurantManagerCost, ref data.BurgerRestaurantAuto, ref data.BurgerRestaurantManagerLevel1);
                break;
            case 9:
                BuyManager(data.BurgerFrancheiseRestaurantManagerCost, ref data.BurgerFrancheiseRestaurantAuto, ref data.BurgerFrancheiseRestaurantManagerLevel1);
                break;
            case 10:
                BuyManager(data.SushiRestaurantManagerCost, ref data.SushiRestaurantAuto, ref data.SushiRestaurantManagerLevel1);
                break;
            case 11:
                BuyManager(data.SushiFrancheiseRestaurantManagerCost, ref data.SushiFrancheiseRestaurantAuto, ref data.SushiFrancheiseRestaurantManagerLevel1);
                break;
            case 12:
                BuyManager(data.PlaneRestaurantManagerCost, ref data.PlaneRestaurantAuto, ref data.PlaneRestaurantManagerLevel1);
                break;
        }
    }
    public void BuyManager(double cost, ref bool auto, ref double level)
    {
        if (data.dollar >= cost)
        {
            level++;
            data.dollar -= cost;
            auto = true;
        }

    }
    public void BuyMaxAll()
    {

        BuyMax(25000, 1.22, ref data.PlaneRestaurantLevel);
        BuyMax(20000, 1.21, ref data.SushiFrancheiseRestaurantLevel);
        BuyMax(17500, 1.2, ref data.SushiRestaurantLevel);
        BuyMax(15000, 1.195, ref data.BurgerFrancheiseRestaurantLevel);
        BuyMax(12500, 1.19, ref data.BurgerRestaurantLevel);
        BuyMax(10000, 1.185, ref data.PizzaFrancheiseRestaurantLevel);
        BuyMax(8000, 1.18, ref data.PizzaRestaurantLevel);
        BuyMax(7000, 1.177, ref data.HotdogFrancheiseRestaurantLevel);
        BuyMax(3500, 1.175, ref data.HotdogRestaurantLevel);
        BuyMax(1875, 1.17, ref data.HotdogBigRestaurantLevel);
        BuyMax(250, 1.16, ref data.HotdogCarLevel);
        BuyMax(10, 1.15, ref data.HotdogCounterLevel);

    }
    public void BuyMax(double b, double r, ref double k)
    {
        var c = data.dollar;
        var n = Floor(Log(c * (r - 1) / (b * Pow(r, k)) + 1, r));

        var cost = b * (Pow(r, k) * (Pow(r, n) - 1) / (r - 1));
        if (data.dollar >= cost)
        {
            k += n;
            data.dollar -= cost;
        }
    }

    public string Notation(double x)
    {
        string result=null;
       if (x >= 1000000) 
        {
            var mantissa = x / 1000000;
           
             result =mantissa.ToString("F3")  + " Million" ;
        }
        if (x >= 1000000000)
        {
            var mantiss = x / 1000000000;

            result = mantiss.ToString("F3") + " Billion";
        }

        if( x>= 1000000000000)
        {
            var manti = x / 1000000000000;
            result = manti.ToString("F3") + " Trillion";
        }
        if (x >= 1000000000000000)
        {
            var mantissa1 = x / 1000000000000000;
            result = mantissa1.ToString("F3") + " Quadrillion";
        }
        if (x >= 1000000000000000000)
        {
            var mantissa1 = x / 1000000000000000000;
            result = mantissa1.ToString("F3") + " Quintillion";
        }
        if (x<1000000)
        {
            result = x.ToString("F0");
        }
        return result;

    }
   public string Notations(double x)
    {
       string result = null;

        second = (int)(x % 60);
        minute = (int)(x / 60 % 60);
        hour = (int)(x / 3600);
        result = string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);            

       return result;
    }
 
    public void UpgradesHotdog(int id)
    {
        switch (id)
        {
            case 1:
                Upgrades1(data.UpgradesHotdogCounterCost, ref data.HotdogCounterMult, ref data.UpgradesHotdogCounterLevel1);
                break;
            case 2:
                Upgrades1(data.UpgradesHotdogCarCost, ref data.HotdogCarMult, ref data.UpgradesHotdogCarLevel1);
                break;
            case 3:
                Upgrades1(data.UpgradesHotdogBigRestaurantCost, ref data.HotdogBigRestaurantMult, ref data.UpgradesHotdogBigRestaurantLevel1);
                break;
            case 4:
                Upgrades1(data.UpgradesHotdogRestaurantCost, ref data.HotdogRestaurantMult, ref data.UpgradesHotdogRestaurantLevel1);
                break;
            case 5:
                Upgrades1(data.UpgradesHotdogFrancheiseRestaurantCost, ref data.HotdogFrancheiseRestaurantMult, ref data.UpgradesHotdogFrancheiseRestaurantLevel1);
                break;
            case 6:
                Upgrades1(data.UpgradesPizzaRestaurantCost, ref data.PizzaRestaurantMult, ref data.UpgradesPizzaRestaurantLevel1);
                break;
            case 7:
                Upgrades1(data.UpgradesPizzaFrancheiseRestaurantCost, ref data.PizzaFrancheiseRestaurantMult, ref data.UpgradesPizzaFrancheiseRestaurantLevel1);
                break;
            case 8:
                Upgrades1(data.UpgradesBurgerRestaurantCost, ref data.BurgerRestaurantMult, ref data.UpgradesBurgerRestaurantLevel1);
                break;
            case 9:
                Upgrades1(data.UpgradesBurgerFrancheiseRestaurantCost, ref data.BurgerFrancheiseRestaurantMult, ref data.UpgradesBurgerFrancheiseRestaurantLevel1);
                break;
            case 10:
                Upgrades1(data.UpgradesSushiRestaurantCost, ref data.SushiRestaurantMult, ref data.UpgradesSushiRestaurantLevel1);
                break;
            case 11:
                Upgrades1(data.UpgradesSushiFrancheiseRestaurantCost, ref data.SushiFrancheiseRestaurantMult, ref data.UpgradesSushiFrancheiseRestaurantLevel1);
                break;
            case 12:
                Upgrades1(data.UpgradesPlaneRestaurantCost, ref data.PlaneRestaurantMult, ref data.UpgradesPlaneRestaurantLevel1);
                break;
        }
    }
  
    public void Upgrades1(double cost, ref double mult, ref double level)
    {
        if (data.dollar >= cost)
        {
            level++;
            data.dollar -= cost;
            mult *= 1.50;
        }
    }
    public void UpgradesHotdog2(int id)
    {
        switch (id)
        {
            case 1:
                Upgrades2(data.UpgradesHotdogCounterCost2, ref data.HotdogCounterMult, ref data.UpgradesHotdogCounterLevel2);
                    break;
            case 2:
                Upgrades2(data.UpgradesHotdogCarCost2, ref data.HotdogCarMult, ref data.UpgradesHotdogCarLevel2);
                break;
            case 3:
                Upgrades2(data.UpgradesHotdogBigRestaurantCost2, ref data.HotdogBigRestaurantMult, ref data.UpgradesHotdogBigRestaurantLevel2);
                break;
            case 4:
                Upgrades2(data.UpgradesHotdogRestaurantCost2, ref data.HotdogRestaurantMult, ref data.UpgradesHotdogRestaurantLevel2);
                break;
            case 5:
                Upgrades2(data.UpgradesHotdogFrancheiseRestaurantCost2, ref data.HotdogFrancheiseRestaurantMult, ref data.UpgradesHotdogFrancheiseRestaurantLevel2);
                break;
            case 6:
                Upgrades2(data.UpgradesPizzaRestaurantCost2, ref data.PizzaRestaurantMult, ref data.UpgradesPizzaRestaurantLevel2);
                break;
            case 7:
                Upgrades2(data.UpgradesPizzaFrancheiseRestaurantCost2, ref data.PizzaFrancheiseRestaurantMult, ref data.UpgradesPizzaFrancheiseRestaurantLevel2);
                break;
            case 8:
                Upgrades2(data.UpgradesBurgerRestaurantCost2, ref data.BurgerRestaurantMult, ref data.UpgradesBurgerRestaurantLevel2);
                break;
            case 9:
                Upgrades2(data.UpgradesBurgerFrancheiseRestaurantCost2, ref data.BurgerFrancheiseRestaurantMult, ref data.UpgradesBurgerFrancheiseRestaurantLevel2);
                break;
            case 10:
                Upgrades2(data.UpgradesSushiRestaurantCost2, ref data.SushiRestaurantMult, ref data.UpgradesSushiRestaurantLevel2);
                break;
            case 11:
                Upgrades2(data.UpgradesSushiFrancheiseRestaurantCost2, ref data.SushiFrancheiseRestaurantMult, ref data.UpgradesSushiFrancheiseRestaurantLevel2);
                break;
            case 12:
                Upgrades2(data.UpgradesPlaneRestaurantCost2, ref data.PlaneRestaurantMult, ref data.UpgradesPlaneRestaurantLevel2);
                break;
        }
    }
    public void Upgrades2(double cost, ref double mult, ref double level)
    {
        if (data.dollar>=cost)
        {
            level++;
            data.dollar -= cost;
            mult *= 1.75;
        }
    }
    public void UpgradesHotdog3(int id)
    {
        switch (id)
        {
            case 1:
                Upgrades3(data.UpgradesHotdogCounterCost3, ref data.HotdogCounterMult, ref data.UpgradesHotdogCounterLevel3);
                break;
            case 2:
                Upgrades3(data.UpgradesHotdogCarCost3, ref data.HotdogCarMult, ref data.UpgradesHotdogCarLevel3);
                break;
            case 3:
                Upgrades3(data.UpgradesHotdogBigRestaurantCost3, ref data.HotdogBigRestaurantMult, ref data.UpgradesHotdogBigRestaurantLevel3);
                break;
            case 4:
                Upgrades3(data.UpgradesHotdogRestaurantCost3, ref data.HotdogRestaurantMult, ref data.UpgradesHotdogRestaurantLevel3);
                break;
            case 5:
                Upgrades3(data.UpgradesHotdogFrancheiseRestaurantCost3, ref data.HotdogFrancheiseRestaurantMult, ref data.UpgradesHotdogFrancheiseRestaurantLevel3);
                break;
            case 6:
                Upgrades3(data.UpgradesPizzaRestaurantCost3, ref data.PizzaRestaurantMult, ref data.UpgradesPizzaRestaurantLevel3);
                break;
            case 7:
                Upgrades3(data.UpgradesPizzaFrancheiseRestaurantCost3, ref data.PizzaFrancheiseRestaurantMult, ref data.UpgradesPizzaFrancheiseRestaurantLevel3);
                break;
            case 8:
                Upgrades3(data.UpgradesBurgerRestaurantCost3, ref data.BurgerRestaurantMult, ref data.UpgradesBurgerRestaurantLevel3);
                break;
            case 9:
                Upgrades3(data.UpgradesBurgerFrancheiseRestaurantCost3, ref data.BurgerFrancheiseRestaurantMult, ref data.UpgradesBurgerFrancheiseRestaurantLevel3);
                break;
            case 10:
                Upgrades3(data.UpgradesSushiRestaurantCost3, ref data.SushiRestaurantMult, ref data.UpgradesSushiRestaurantLevel3);
                break;
            case 11:
                Upgrades3(data.UpgradesSushiFrancheiseRestaurantCost3, ref data.SushiFrancheiseRestaurantMult, ref data.UpgradesSushiFrancheiseRestaurantLevel3);
                break;
            case 12:
                Upgrades3(data.UpgradesPlaneRestaurantCost3, ref data.PlaneRestaurantMult, ref data.UpgradesPlaneRestaurantLevel3);
                break;
        }
    }
    public void Upgrades3(double cost, ref double mult, ref double level)
    {
        if (data.dollar >= cost)
        {
            level++;
            data.dollar -= cost;
            mult *= 2.00;
        }
    }
    public void UpgradesHotdog4(int id)
    {
        switch (id)
        {
            case 1:
                Upgrades4(data.UpgradesHotdogCounterCost4, ref data.HotdogCounterMult, ref data.UpgradesHotdogCounterLevel4);
                break;
            case 2:
                Upgrades4(data.UpgradesHotdogCarCost4, ref data.HotdogCarMult, ref data.UpgradesHotdogCarLevel4);
                break;
            case 3:
                Upgrades4(data.UpgradesHotdogBigRestaurantCost4, ref data.HotdogBigRestaurantMult, ref data.UpgradesHotdogBigRestaurantLevel4);
                break;
            case 4:
                Upgrades4(data.UpgradesHotdogRestaurantCost4, ref data.HotdogRestaurantMult, ref data.UpgradesHotdogRestaurantLevel4);
                break;
            case 5:
                Upgrades4(data.UpgradesHotdogFrancheiseRestaurantCost4, ref data.HotdogFrancheiseRestaurantMult, ref data.UpgradesHotdogFrancheiseRestaurantLevel4);
                break;
            case 6:
                Upgrades4(data.UpgradesPizzaRestaurantCost4, ref data.PizzaRestaurantMult, ref data.UpgradesPizzaRestaurantLevel4);
                break;
            case 7:
                Upgrades4(data.UpgradesPizzaFrancheiseRestaurantCost4, ref data.PizzaFrancheiseRestaurantMult, ref data.UpgradesPizzaFrancheiseRestaurantLevel4);
                break;
            case 8:
                Upgrades4(data.UpgradesBurgerRestaurantCost4, ref data.BurgerRestaurantMult, ref data.UpgradesBurgerRestaurantLevel4);
                break;
            case 9:
                Upgrades4(data.UpgradesBurgerFrancheiseRestaurantCost4, ref data.BurgerFrancheiseRestaurantMult, ref data.UpgradesBurgerFrancheiseRestaurantLevel4);
                break;
            case 10:
                Upgrades4(data.UpgradesSushiRestaurantCost4, ref data.SushiRestaurantMult, ref data.UpgradesSushiRestaurantLevel4);
                break;
            case 11:
                Upgrades4(data.UpgradesSushiFrancheiseRestaurantCost4, ref data.SushiFrancheiseRestaurantMult, ref data.UpgradesSushiFrancheiseRestaurantLevel4);
                break;
            case 12:
                Upgrades4(data.UpgradesPlaneRestaurantCost4, ref data.PlaneRestaurantMult, ref data.UpgradesPlaneRestaurantLevel4);
                break;
        }
    }
    public void Upgrades4(double cost, ref double mult, ref double level)
    {
        if (data.dollar >= cost)
        {
            level++;
            data.dollar -= cost;
            mult *= 2.50;
        }
    }
    public void Start()
    {
   
    data.FullReset();

        HotdogCarButton.interactable = false;
        HotdogBigRestaurantButton.interactable = false;
        HotdogRestaurantButton.interactable = false;
        HotdogFrancheiseRestaurantButton.interactable = false;
        PizzaRestaurantButton.interactable = false;
        PizzaFrancheiseRestaurantButton.interactable = false;
        BurgerRestaurantButton.interactable = false;
        BurgerFrancheiseRestaurantButton.interactable = false;
        SushiRestaurantButton.interactable = false;
        SushiFrancheiseRestaurantButton.interactable = false;
        PlaneRestaurantButton.interactable = false;

        UpgradesHotdogCounterButton1.interactable = false;
        UpgradesHotdogCarButton1.interactable = false;
        UpgradesHotdogBigRestaurantButton1.interactable = false;
        UpgradesHotdogRestaurantButton1.interactable = false;
        UpgradesHotdogFrancheiseRestaurantButton1.interactable = false;
        UpgradesPizzaRestaurantButton1.interactable = false;
        UpgradesPizzaFrancheiseRestaurantButton1.interactable = false;
        UpgradesBurgerRestaurantButton1.interactable = false;
        UpgradesBurgerFrancheiseRestaurantButton1.interactable = false;
        UpgradesSushiRestaurantButton1.interactable = false;
        UpgradesSushiFrancheiseRestaurantButton1.interactable = false;
        UpgradesPlaneRestaurantButton1.interactable = false;

        UpgradesHotdogCounterButton2.interactable = false;
        UpgradesHotdogCarButton2.interactable = false;
        UpgradesHotdogBigRestaurantButton2.interactable = false;
        UpgradesHotdogRestaurantButton2.interactable = false;
        UpgradesHotdogFrancheiseRestaurantButton2.interactable = false;
        UpgradesPizzaRestaurantButton2.interactable = false;
        UpgradesPizzaFrancheiseRestaurantButton2.interactable = false;
        UpgradesBurgerRestaurantButton2.interactable = false;
        UpgradesBurgerFrancheiseRestaurantButton2.interactable = false;
        UpgradesSushiRestaurantButton2.interactable = false;
        UpgradesSushiFrancheiseRestaurantButton2.interactable = false;
        UpgradesPlaneRestaurantButton2.interactable = false;

        UpgradesHotdogCounterButton3.interactable = false;
        UpgradesHotdogCarButton3.interactable = false;
        UpgradesHotdogBigRestaurantButton3.interactable = false;
        UpgradesHotdogRestaurantButton3.interactable = false;
        UpgradesHotdogFrancheiseRestaurantButton3.interactable = false;
        UpgradesPizzaRestaurantButton3.interactable = false;
        UpgradesPizzaFrancheiseRestaurantButton3.interactable = false;
        UpgradesBurgerRestaurantButton3.interactable = false;
        UpgradesBurgerFrancheiseRestaurantButton3.interactable = false;
        UpgradesSushiRestaurantButton3.interactable = false;
        UpgradesSushiFrancheiseRestaurantButton3.interactable = false;
        UpgradesPlaneRestaurantButton3.interactable = false;

        UpgradesHotdogCounterButton4.interactable = false;
        UpgradesHotdogCarButton4.interactable = false;
        UpgradesHotdogBigRestaurantButton4.interactable = false;
        UpgradesHotdogRestaurantButton4.interactable = false;
        UpgradesHotdogFrancheiseRestaurantButton4.interactable = false;
        UpgradesPizzaRestaurantButton4.interactable = false;
        UpgradesPizzaFrancheiseRestaurantButton4.interactable = false;
        UpgradesBurgerRestaurantButton4.interactable = false;
        UpgradesBurgerFrancheiseRestaurantButton4.interactable = false;
        UpgradesSushiRestaurantButton4.interactable = false;
        UpgradesSushiFrancheiseRestaurantButton4.interactable = false;
        UpgradesPlaneRestaurantButton4.interactable = false;

        HotdogCounterManagerButton1.interactable = false;
        HotdogCarManagerButton1.interactable = false;
        HotdogBigRestaurantManagerButton1.interactable = false;
        HotdogRestaurantManagerButton1.interactable = false;
        HotdogFrancheiseRestaurantManagerButton1.interactable = false;
        PizzaRestaurantManagerButton1.interactable = false;
        PizzaFrancheiseRestaurantManagerButton1.interactable = false;
        BurgerRestaurantManagerButton1.interactable = false;
        BurgerFrancheiseRestaurantManagerButton1.interactable = false;
        SushiRestaurantManagerButton1.interactable = false;
        SushiFrancheiseRestaurantManagerButton1.interactable = false;
        PlaneRestaurantManagerButton1.interactable = false;

    }

    public void Update()
    {
        DollarText.text = Notation(data.dollar) + " $";
        RunHotdogs();
        RunUpgrades();
        RunManagers();
        RunUpgrades2();
        RunUpgrades3();
        RunUpgrades4();
        //Shops interactable function

        if (data.dollar >= data.HotdogCounterCost)
        {
            HotdogCounterButton.interactable = true;
        }
        else if (data.dollar <= data.HotdogCounterCost)
        {
            HotdogCounterButton.interactable = false;
        }
        if (data.dollar >= data.HotdogCarCost)
        {
            HotdogCarButton.interactable = true;
        }
        else if (data.dollar <= data.HotdogCarCost)
        {
            HotdogCarButton.interactable = false;
        }
        if (data.dollar >= data.HotdogBigRestaurantCost)
        {
            HotdogBigRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.HotdogBigRestaurantCost)
        {
            HotdogBigRestaurantButton.interactable = false;
        }
        if (data.dollar >= data.HotdogRestaurantCost)
        {
            HotdogRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.HotdogRestaurantCost)
        {
            HotdogRestaurantButton.interactable = false;
        }
        if (data.dollar >= data.HotdogFrancheiseRestaurantCost)
        {
            HotdogFrancheiseRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.HotdogFrancheiseRestaurantCost)
        {
            HotdogFrancheiseRestaurantButton.interactable = false;
        }
        if (data.dollar >= data.PizzaRestaurantCost)
        {
            PizzaRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.PizzaRestaurantCost)
        {
            PizzaRestaurantButton.interactable = false;
        }
        if (data.dollar >= data.PizzaFrancheiseRestaurantCost)
        {
            PizzaFrancheiseRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.PizzaFrancheiseRestaurantCost)
        {
            PizzaFrancheiseRestaurantButton.interactable = false;
        }
        if (data.dollar >= data.BurgerRestaurantCost)
        {
            BurgerRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.BurgerRestaurantCost)
        {
            BurgerRestaurantButton.interactable = false;
        }
        if (data.dollar >= data.BurgerFrancheiseRestaurantCost)
        {
            BurgerFrancheiseRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.BurgerFrancheiseRestaurantCost)
        {
            BurgerFrancheiseRestaurantButton.interactable = false;
        }
        if (data.dollar >= data.SushiRestaurantCost)
        {
            SushiRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.SushiRestaurantCost)
        {
            SushiRestaurantButton.interactable = false;
        }
        if (data.dollar >= data.SushiFrancheiseRestaurantCost)
        {
            SushiFrancheiseRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.BurgerFrancheiseRestaurantCost)
        {
            SushiFrancheiseRestaurantButton.interactable = false;
        }
        if (data.dollar >= data.PlaneRestaurantCost)
        {
            PlaneRestaurantButton.interactable = true;
        }
        else if (data.dollar <= data.PlaneRestaurantCost)
        {
            PlaneRestaurantButton.interactable = false;
        }
        //UpgradesHotdog interactable func
        if (data.dollar >= data.UpgradesHotdogCounterCost)
        {
            UpgradesHotdogCounterButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogCounterCost)
        {
            UpgradesHotdogCounterButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogCarCost)
        {
            UpgradesHotdogCarButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogCarCost)
        {
            UpgradesHotdogCarButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogBigRestaurantCost)
        {
            UpgradesHotdogBigRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogBigRestaurantCost)
        {
            UpgradesHotdogBigRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogRestaurantCost)
        {
            UpgradesHotdogRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogRestaurantCost)
        {
            UpgradesHotdogRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogFrancheiseRestaurantCost)
        {
            UpgradesHotdogFrancheiseRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogFrancheiseRestaurantCost)
        {
            UpgradesHotdogFrancheiseRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesPizzaRestaurantCost)
        {
            UpgradesPizzaRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPizzaRestaurantCost)
        {
            UpgradesPizzaRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesPizzaFrancheiseRestaurantCost)
        {
            UpgradesPizzaFrancheiseRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPizzaFrancheiseRestaurantCost)
        {
            UpgradesPizzaFrancheiseRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesBurgerRestaurantCost)
        {
            UpgradesBurgerRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesBurgerRestaurantCost)
        {
            UpgradesBurgerRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesBurgerFrancheiseRestaurantCost)
        {
            UpgradesBurgerFrancheiseRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesBurgerFrancheiseRestaurantCost)
        {
            UpgradesBurgerFrancheiseRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesSushiRestaurantCost)
        {
            UpgradesSushiRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesSushiRestaurantCost)
        {
            UpgradesSushiRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesSushiFrancheiseRestaurantCost)
        {
            UpgradesSushiFrancheiseRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesSushiFrancheiseRestaurantCost)
        {
            UpgradesSushiFrancheiseRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesPlaneRestaurantCost)
        {
            UpgradesPlaneRestaurantButton1.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPlaneRestaurantCost)
        {
            UpgradesPlaneRestaurantButton1.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogCounterCost2)
        {
            UpgradesHotdogCounterButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogCounterCost2)
        {
            UpgradesHotdogCounterButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogCarCost2)
        {
            UpgradesHotdogCarButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogCarCost2)
        {
            UpgradesHotdogCarButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogBigRestaurantCost2)
        {
            UpgradesHotdogBigRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogBigRestaurantCost2)
        {
            UpgradesHotdogBigRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogRestaurantCost2)
        {
            UpgradesHotdogRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogRestaurantCost2)
        {
            UpgradesHotdogRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogFrancheiseRestaurantCost2)
        {
            UpgradesHotdogFrancheiseRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogFrancheiseRestaurantCost2)
        {
            UpgradesHotdogFrancheiseRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesPizzaRestaurantCost2)
        {
            UpgradesPizzaRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPizzaRestaurantCost2)
        {
            UpgradesPizzaRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesPizzaFrancheiseRestaurantCost2)
        {
            UpgradesPizzaFrancheiseRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPizzaFrancheiseRestaurantCost2)
        {
            UpgradesPizzaFrancheiseRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesBurgerRestaurantCost2)
        {
            UpgradesBurgerRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesBurgerRestaurantCost2)
        {
            UpgradesBurgerRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesBurgerFrancheiseRestaurantCost2)
        {
            UpgradesBurgerFrancheiseRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesBurgerFrancheiseRestaurantCost2)
        {
            UpgradesBurgerFrancheiseRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesSushiRestaurantCost2)
        {
            UpgradesSushiRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesSushiRestaurantCost2)
        {
            UpgradesSushiRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesSushiFrancheiseRestaurantCost2)
        {
            UpgradesSushiFrancheiseRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesSushiFrancheiseRestaurantCost2)
        {
            UpgradesSushiFrancheiseRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesPlaneRestaurantCost2)
        {
            UpgradesPlaneRestaurantButton2.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPlaneRestaurantCost2)
        {
            UpgradesPlaneRestaurantButton2.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogCounterCost3)
        {
            UpgradesHotdogCounterButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogCounterCost3)
        {
            UpgradesHotdogCounterButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogCarCost3)
        {
            UpgradesHotdogCarButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogCarCost3)
        {
            UpgradesHotdogCarButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogBigRestaurantCost3)
        {
            UpgradesHotdogBigRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogBigRestaurantCost3)
        {
            UpgradesHotdogBigRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogRestaurantCost3)
        {
            UpgradesHotdogRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogRestaurantCost3)
        {
            UpgradesHotdogRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogFrancheiseRestaurantCost3)
        {
            UpgradesHotdogFrancheiseRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogFrancheiseRestaurantCost3)
        {
            UpgradesHotdogFrancheiseRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesPizzaRestaurantCost3)
        {
            UpgradesPizzaRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPizzaRestaurantCost3)
        {
            UpgradesPizzaRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesPizzaFrancheiseRestaurantCost3)
        {
            UpgradesPizzaFrancheiseRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPizzaFrancheiseRestaurantCost3)
        {
            UpgradesPizzaFrancheiseRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesBurgerRestaurantCost3)
        {
            UpgradesBurgerRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesBurgerRestaurantCost3)
        {
            UpgradesBurgerRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesBurgerFrancheiseRestaurantCost3)
        {
            UpgradesBurgerFrancheiseRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesBurgerFrancheiseRestaurantCost3)
        {
            UpgradesBurgerFrancheiseRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesSushiRestaurantCost3)
        {
            UpgradesSushiRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesSushiRestaurantCost3)
        {
            UpgradesSushiRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesSushiFrancheiseRestaurantCost3)
        {
            UpgradesSushiFrancheiseRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesSushiFrancheiseRestaurantCost3)
        {
            UpgradesSushiFrancheiseRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesPlaneRestaurantCost3)
        {
            UpgradesPlaneRestaurantButton3.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPlaneRestaurantCost3)
        {
            UpgradesPlaneRestaurantButton3.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogCounterCost4)
        {
            UpgradesHotdogCounterButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogCounterCost4)
        {
            UpgradesHotdogCounterButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogCarCost4)
        {
            UpgradesHotdogCarButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogCarCost4)
        {
            UpgradesHotdogCarButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogBigRestaurantCost4)
        {
            UpgradesHotdogBigRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogBigRestaurantCost4)
        {
            UpgradesHotdogBigRestaurantButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogRestaurantCost4)
        {
            UpgradesHotdogRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogRestaurantCost4)
        {
            UpgradesHotdogRestaurantButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesHotdogFrancheiseRestaurantCost4)
        {
            UpgradesHotdogFrancheiseRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesHotdogFrancheiseRestaurantCost4)
        {
            UpgradesHotdogFrancheiseRestaurantButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesPizzaRestaurantCost4)
        {
            UpgradesPizzaRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPizzaRestaurantCost4)
        {
            UpgradesPizzaRestaurantButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesPizzaFrancheiseRestaurantCost4)
        {
            UpgradesPizzaFrancheiseRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPizzaFrancheiseRestaurantCost4)
        {
            UpgradesPizzaFrancheiseRestaurantButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesBurgerRestaurantCost4)
        {
            UpgradesBurgerRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesBurgerRestaurantCost4)
        {
            UpgradesBurgerRestaurantButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesBurgerFrancheiseRestaurantCost4)
        {
            UpgradesBurgerFrancheiseRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesBurgerFrancheiseRestaurantCost4)
        {
            UpgradesBurgerFrancheiseRestaurantButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesSushiRestaurantCost4)
        {
            UpgradesSushiRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesSushiRestaurantCost4)
        {
            UpgradesSushiRestaurantButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesSushiFrancheiseRestaurantCost4)
        {
            UpgradesSushiFrancheiseRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesSushiFrancheiseRestaurantCost4)
        {
            UpgradesSushiFrancheiseRestaurantButton4.interactable = false;
        }
        if (data.dollar >= data.UpgradesPlaneRestaurantCost4)
        {
            UpgradesPlaneRestaurantButton4.interactable = true;
        }
        else if (data.dollar <= data.UpgradesPlaneRestaurantCost4)
        {
            UpgradesPlaneRestaurantButton4.interactable = false;
        }
        //ManagerButton Interactable Function
        if (data.dollar >= data.HotdogCounterManagerCost)
        {
            HotdogCounterManagerButton1.interactable = true;
        }
        else if(data.dollar<=data.HotdogCounterManagerCost)
        {
            HotdogCounterManagerButton1.interactable = false;
        }
        if (data.dollar >= data.HotdogCarManagerCost)
        {
            HotdogCarManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.HotdogCarManagerCost)
        {
            HotdogCarManagerButton1.interactable = false;
        }
        if (data.dollar >= data.HotdogBigRestaurantManagerCost)
        {
            HotdogBigRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.HotdogBigRestaurantManagerCost)
        {
            HotdogBigRestaurantManagerButton1.interactable = false;
        }
        if (data.dollar >= data.HotdogRestaurantManagerCost)
        {
            HotdogRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.HotdogRestaurantManagerCost)
        {
            HotdogRestaurantManagerButton1.interactable = false;
        }
        if (data.dollar >= data.HotdogFrancheiseRestaurantManagerCost)
        {
            HotdogFrancheiseRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.HotdogFrancheiseRestaurantManagerCost)
        {
            HotdogFrancheiseRestaurantManagerButton1.interactable = false;
        }
        if (data.dollar >= data.PizzaRestaurantManagerCost)
        {
            PizzaRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.PizzaRestaurantManagerCost)
        {
            PizzaRestaurantManagerButton1.interactable = false;
        }
        if (data.dollar >= data.PizzaFrancheiseRestaurantManagerCost)
        {
            PizzaFrancheiseRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.PizzaFrancheiseRestaurantManagerCost)
        {
            PizzaFrancheiseRestaurantManagerButton1.interactable = false;
        }
        if (data.dollar >= data.BurgerRestaurantManagerCost)
        {
            BurgerRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.BurgerRestaurantManagerCost)
        {
            BurgerRestaurantManagerButton1.interactable = false;
        }
        if (data.dollar >= data.BurgerFrancheiseRestaurantManagerCost)
        {
            BurgerFrancheiseRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.BurgerFrancheiseRestaurantManagerCost)
        {
            BurgerFrancheiseRestaurantManagerButton1.interactable = false;
        }
        if (data.dollar >= data.SushiRestaurantManagerCost)
        {
            SushiRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.SushiRestaurantManagerCost)
        {
            SushiRestaurantManagerButton1.interactable = false;
        }
        if (data.dollar >= data.SushiFrancheiseRestaurantManagerCost)
        {
            SushiFrancheiseRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.SushiFrancheiseRestaurantManagerCost)
        {
            SushiFrancheiseRestaurantManagerButton1.interactable = false;
        }
        if (data.dollar >= data.PlaneRestaurantManagerCost)
        {
            PlaneRestaurantManagerButton1.interactable = true;
        }
        else if (data.dollar <= data.PlaneRestaurantManagerCost)
        {
            PlaneRestaurantManagerButton1.interactable = false;
        }
    }
    

    public void DestroyUpgrades(int id)
    {
        switch (id)
        {
            case 1:
                DestroyUpgrade( UpgradesHotdogCounter1,data.UpgradesHotdogCounterLevel1);
                break;
            case 2:
                DestroyUpgrade(UpgradesHotdogCar1, data.UpgradesHotdogCarLevel1);
                break;
            case 3:
                DestroyUpgrade(UpgradesHotdogBigRestaurant1, data.UpgradesHotdogBigRestaurantLevel1);
                break;
            case 4:
                DestroyUpgrade(UpgradesHotdogRestaurant1, data.UpgradesHotdogRestaurantLevel1);
                break;
            case 5:
                DestroyUpgrade(UpgradesHotdogFrancheiseRestaurant1, data.UpgradesHotdogFrancheiseRestaurantLevel1);
                break;
            case 6:
                DestroyUpgrade(UpgradesPizzaRestaurant1, data.UpgradesPizzaRestaurantLevel1);
                break;
            case 7:
                DestroyUpgrade(UpgradesPizzaFrancheiseRestaurant1, data.UpgradesPizzaFrancheiseRestaurantLevel1);
                break;
            case 8:
                DestroyUpgrade(UpgradesBurgerRestaurant1, data.UpgradesBurgerRestaurantLevel1);
                break;
            case 9:
                DestroyUpgrade(UpgradesBurgerFrancheiseRestaurant1, data.UpgradesBurgerFrancheiseRestaurantLevel1);
                break;
            case 10:
                DestroyUpgrade(UpgradesSushiRestaurant1, data.UpgradesSushiRestaurantLevel1);
                break;
            case 11:
                DestroyUpgrade(UpgradesSushiFrancheiseRestaurant1, data.UpgradesSushiFrancheiseRestaurantLevel1);
                break;
            case 12:
                DestroyUpgrade(UpgradesPlaneRestaurant1, data.UpgradesPlaneRestaurantLevel1);
                break;
        }
            
    }
    public void DestroyUpgrades2(int id)
    {
        switch (id)
        {
            case 1:
                DestroyUpgrade(UpgradesHotdogCounter2, data.UpgradesHotdogCounterLevel2);
                break;
            case 2:
                DestroyUpgrade(UpgradesHotdogCar2, data.UpgradesHotdogCarLevel2);
                break;
            case 3:
                DestroyUpgrade(UpgradesHotdogBigRestaurant2, data.UpgradesHotdogBigRestaurantLevel2);
                break;
            case 4:
                DestroyUpgrade(UpgradesHotdogRestaurant2, data.UpgradesHotdogRestaurantLevel2);
                break;
            case 5:
                DestroyUpgrade(UpgradesHotdogFrancheiseRestaurant2, data.UpgradesHotdogFrancheiseRestaurantLevel2);
                break;
            case 6:
                DestroyUpgrade(UpgradesPizzaRestaurant2, data.UpgradesPizzaRestaurantLevel2);
                break;
            case 7:
                DestroyUpgrade(UpgradesPizzaFrancheiseRestaurant2, data.UpgradesPizzaFrancheiseRestaurantLevel2);
                break;
            case 8:
                DestroyUpgrade(UpgradesBurgerRestaurant2, data.UpgradesBurgerRestaurantLevel2);
                break;
            case 9:
                DestroyUpgrade(UpgradesBurgerFrancheiseRestaurant2, data.UpgradesBurgerFrancheiseRestaurantLevel2);
                break;
            case 10:
                DestroyUpgrade(UpgradesSushiRestaurant2, data.UpgradesSushiRestaurantLevel2);
                break;
            case 11:
                DestroyUpgrade(UpgradesSushiFrancheiseRestaurant2, data.UpgradesSushiFrancheiseRestaurantLevel2);
                break;
            case 12:
                DestroyUpgrade(UpgradesPlaneRestaurant2, data.UpgradesPlaneRestaurantLevel2);
                break;
        }
    }
    public void DestroyUpgrades3(int id)
    {
        switch (id)
        {
            case 1:
                DestroyUpgrade(UpgradesHotdogCounter3, data.UpgradesHotdogCounterLevel3);
                break;
            case 2:
                DestroyUpgrade(UpgradesHotdogCar3, data.UpgradesHotdogCarLevel3);
                break;
            case 3:
                DestroyUpgrade(UpgradesHotdogBigRestaurant3, data.UpgradesHotdogBigRestaurantLevel3);
                break;
            case 4:
                DestroyUpgrade(UpgradesHotdogRestaurant3, data.UpgradesHotdogRestaurantLevel3);
                break;
            case 5:
                DestroyUpgrade(UpgradesHotdogFrancheiseRestaurant3, data.UpgradesHotdogFrancheiseRestaurantLevel3);
                break;
            case 6:
                DestroyUpgrade(UpgradesPizzaRestaurant3, data.UpgradesPizzaRestaurantLevel3);
                break;
            case 7:
                DestroyUpgrade(UpgradesPizzaFrancheiseRestaurant3, data.UpgradesPizzaFrancheiseRestaurantLevel3);
                break;
            case 8:
                DestroyUpgrade(UpgradesBurgerRestaurant3, data.UpgradesBurgerRestaurantLevel3);
                break;
            case 9:
                DestroyUpgrade(UpgradesBurgerFrancheiseRestaurant3, data.UpgradesBurgerFrancheiseRestaurantLevel3);
                break;
            case 10:
                DestroyUpgrade(UpgradesSushiRestaurant3, data.UpgradesSushiRestaurantLevel3);
                break;
            case 11:
                DestroyUpgrade(UpgradesSushiFrancheiseRestaurant3, data.UpgradesSushiFrancheiseRestaurantLevel3);
                break;
            case 12:
                DestroyUpgrade(UpgradesPlaneRestaurant3, data.UpgradesPlaneRestaurantLevel3);
                break;
        }
    }
    public void DestroyUpgrades4(int id)
    {
        switch (id)
        {
            case 1:
                DestroyUpgrade(UpgradesHotdogCounter4, data.UpgradesHotdogCounterLevel4);
                break;
            case 2:
                DestroyUpgrade(UpgradesHotdogCar4, data.UpgradesHotdogCarLevel4);
                break;
            case 3:
                DestroyUpgrade(UpgradesHotdogBigRestaurant4, data.UpgradesHotdogBigRestaurantLevel4);
                break;
            case 4:
                DestroyUpgrade(UpgradesHotdogRestaurant4, data.UpgradesHotdogRestaurantLevel4);
                break;
            case 5:
                DestroyUpgrade(UpgradesHotdogFrancheiseRestaurant4, data.UpgradesHotdogFrancheiseRestaurantLevel4);
                break;
            case 6:
                DestroyUpgrade(UpgradesPizzaRestaurant4, data.UpgradesPizzaRestaurantLevel4);
                break;
            case 7:
                DestroyUpgrade(UpgradesPizzaFrancheiseRestaurant4, data.UpgradesPizzaFrancheiseRestaurantLevel4);
                break;
            case 8:
                DestroyUpgrade(UpgradesBurgerRestaurant4, data.UpgradesBurgerRestaurantLevel4);
                break;
            case 9:
                DestroyUpgrade(UpgradesBurgerFrancheiseRestaurant4, data.UpgradesBurgerFrancheiseRestaurantLevel4);
                break;
            case 10:
                DestroyUpgrade(UpgradesSushiRestaurant4, data.UpgradesSushiRestaurantLevel4);
                break;
            case 11:
                DestroyUpgrade(UpgradesSushiFrancheiseRestaurant4, data.UpgradesSushiFrancheiseRestaurantLevel4);
                break;
            case 12:
                DestroyUpgrade(UpgradesPlaneRestaurant4, data.UpgradesPlaneRestaurantLevel4);
                break;
        }
    }
    public void DestroyUpgrade(GameObject GameO,double level)
    {
        if (level >= 1)
        {
            GameO.SetActive(false);
        }
    }
    public void DestroyManagers(int id)
    {
        switch (id)
        {
            case 1:
                DestroyManager(HotdogCounterManager, data.HotdogCounterManagerLevel1);
            break;
            case 2:
                DestroyManager(HotdogCarManager, data.HotdogCarManagerLevel1);
                break;
            case 3:
                DestroyManager(HotdogBigRestaurantManager, data.HotdogBigRestaurantManagerLevel1);
                break;
            case 4:
                DestroyManager(HotdogRestaurantManager, data.HotdogRestaurantManagerLevel1);
                break;
            case 5:
                DestroyManager(HotdogFrancheiseRestaurantManager, data.HotdogFrancheiseRestaurantManagerLevel1);
                break;
            case 6:
                DestroyManager(PizzaRestaurantManager, data.PizzaRestaurantManagerLevel1);
                break;
            case 7:
                DestroyManager(PizzaFrancheiseRestaurantManager, data.PizzaFrancheiseRestaurantManagerLevel1);
                break;
            case 8:
                DestroyManager(BurgerRestaurantManager, data.BurgerRestaurantManagerLevel1);
                break;
            case 9:
                DestroyManager(BurgerFrancheiseRestaurantManager, data.BurgerFrancheiseRestaurantManagerLevel1);
                break;
            case 10:
                DestroyManager(SushiRestaurantManager, data.SushiRestaurantManagerLevel1);
                break;
            case 11:
                DestroyManager(SushiFrancheiseRestaurantManager, data.SushiFrancheiseRestaurantManagerLevel1);
                break;
            case 12:
                DestroyManager(PlaneRestaurantManager, data.PlaneRestaurantManagerLevel1);
                break;

        }

    }
    public void DestroyManager(GameObject GameO,double level)
    {
        if (level >= 1)
        {
            GameO.SetActive(false);
        }
    }
    public void OpenManager()
    {
        ManagersPanel.SetActive(true);
        UpgradesButton.SetActive(false);
        AchivementButton.SetActive(false);
    }
    public void CloseManagers()
    {
        ManagersPanel.SetActive(false);
        UpgradesButton.SetActive(true);
        AchivementButton.SetActive(true);
    }
    public void OpenUpgrades()
    {
        UpgradesPanel.SetActive(true);
        AchivementButton.SetActive(false);
    }
    public void CloseUpgrades()
    {
        UpgradesPanel.SetActive(false);
        AchivementButton.SetActive(true); ;
    }
    public void OpenAchivement()
    {
        AchivementPanel.SetActive(true);
    }
    public void CloseAchivement()
    {
        AchivementPanel.SetActive(false);
    }
}
