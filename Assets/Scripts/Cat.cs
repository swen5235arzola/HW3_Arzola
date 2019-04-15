using UnityEngine;
/// <summary>
/// Author: Adriana Arzola
/// SWEN 5235 - HW 3 Cats
/// </summary>
namespace Assets.Scripts
{
    public class Cat
    {
        #region Enums
        /// <summary>
        /// Fur Color Options
        /// </summary>
        public enum FurOptions
        {
            GREY,
            BLACK,
            BROWN
        }

        /// <summary>
        /// Eye Color Options
        /// </summary>
        public enum EyeOptions
        {
            BROWN,
            BLUE,
            GREEN
        }
        #endregion

        #region Properties
        public GameObject cat;

        private FurOptions furColor;

        public FurOptions FurColor
        {
            get { return furColor; }
            set
            {
                furColor = value;
                this.UpdateFurColor(this.furColor);
            }
        }

        private string eyeColor;

        public string EyeColor
        {
            get { return eyeColor; }
            set { eyeColor = value; }
        }
        #endregion

        /// <summary>
        /// Update Cat Fur Color
        /// </summary>
        /// <param name="furColor"></param>
        public void UpdateFurColor(FurOptions furColor)
        {
            switch (furColor)
            {
                case FurOptions.BLACK:
                    this.cat.GetComponent<Renderer>().material.color = Color.black;
                    break;
                case FurOptions.BROWN:
                    this.cat.GetComponent<Renderer>().material.color = new Color(139f, 69f, 19f);
                    break;
                case FurOptions.GREY:
                    this.cat.GetComponent<Renderer>().material.color = Color.grey;
                    break;
            }
        }

        /// <summary>
        /// Update Cat Eye Color
        /// </summary>
        /// <param name="eyeColor"></param>
        public void UpdateEyeColor(EyeOptions eyeColor)
        {
            switch (eyeColor)
            {
                case EyeOptions.BLUE:
                    this.cat.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case EyeOptions.BROWN:
                    this.cat.GetComponent<Renderer>().material.color = new Color(139f, 69f, 19f);
                    break;
                case EyeOptions.GREEN:
                    this.cat.GetComponent<Renderer>().material.color = Color.green;
                    break;
            }
        }
    }
}
