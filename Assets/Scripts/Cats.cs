using Assets.Scripts;
using UnityEngine;

/// <summary>
/// Author: Adriana Arzola
/// SWEN 5235 - HW 3 Cats
/// </summary>
public class Cats : MonoBehaviour
{
    public GameObject cat;
    public Transform[] spawnPoints;

    private int greyCatsCount;
    private int brownCatsCount;
    private bool blackCatBlueEyes;
    private bool blackCatBrownEyes;
    private bool blackCatGreenEyes;
    private System.Random rand;

    void Start()
    {
        rand = new System.Random();
    }

    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            this.Spawn();
        }
    }

    /// <summary>
    /// Spawn new Cat into existance
    /// </summary>
    public void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        if (FightManager.numCats < 7)
        {
            //set characteristics
            var colorValue = this.rand.Next(0,2);
            var furColor = (Cat.FurOptions) colorValue;
            var eyeValue = this.rand.Next(0, 2);
            var eyeColor = (Cat.EyeOptions) eyeValue;
            this.SetCatDescription(furColor, eyeColor);

            Instantiate(cat, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            FightManager.numCats++;
            FightManager.fight = this.determineFight(furColor, eyeColor);
        }
    }

    /// <summary>
    /// Determine if Cats are fighting
    /// </summary>
    /// <param name="furColor"></param>
    /// <param name="eyeColor"></param>
    /// <returns></returns>
    public bool determineFight(Cat.FurOptions furColor, Cat.EyeOptions eyeColor)
    {
        switch (furColor)
        {
            case Cat.FurOptions.BLACK:
                if (eyeColor.Equals(Cat.EyeOptions.BLUE))
                {
                    this.blackCatBlueEyes = true;
                }
                else if (eyeColor.Equals(Cat.EyeOptions.BROWN))
                {
                    this.blackCatBrownEyes = true;
                }
                else if (eyeColor.Equals(Cat.EyeOptions.GREEN))
                {
                    this.blackCatGreenEyes = true; 
                }
                break;
            case Cat.FurOptions.BROWN:
                this.brownCatsCount++;
                break;
            case Cat.FurOptions.GREY:
                this.greyCatsCount++;
                break;
        }

        if ((this.greyCatsCount > this.brownCatsCount) && this.brownCatsCount > 0)
        { return true; }

        if (blackCatBlueEyes && blackCatBrownEyes && blackCatGreenEyes)
        { return true; }

        return false;
    }

    // Set UI text to show cat description
    private void SetCatDescription(Cat.FurOptions fur, Cat.EyeOptions eyes)
    {
        CatTextManager.description = fur.ToString() + " Cat " + eyes.ToString() + " Eyes" ;
    }
}
