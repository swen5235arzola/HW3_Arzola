using UnityEngine;
/// <summary>
/// Author: Adriana Arzola
/// SWEN 5235 - HW 3 Cats
/// </summary>
namespace Assets.Scripts
{
    public class Cat:MonoBehaviour
    {
        public Material[] furColors;
        public Material[] eyeColors;
        public GameObject body;
        public GameObject[] eyes;

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
        private FurOptions furColor;

        public FurOptions FurColor
        {
            get { return furColor; }
            set
            {
                furColor = value;
                this.UpdateFurColor(this.body, this.furColor);
            }
        }

        private EyeOptions eyeColor;

        public EyeOptions EyeColor
        {
            get { return eyeColor; }
            set
            {
                eyeColor = value;
                this.UpdateEyeColor(this.eyes, this.eyeColor);
            }
        }
        #endregion

        /// <summary>
        /// Update Cat Fur Color
        /// </summary>
        /// <param name="furColor"></param>
        public void UpdateFurColor(GameObject obj, FurOptions furColor)
        {
            switch (furColor)
            {
                case FurOptions.BLACK:
                    obj.GetComponent<Renderer>().sharedMaterial = furColors[0];
                    break;
                case FurOptions.BROWN:
                    obj.GetComponent<Renderer>().sharedMaterial = furColors[1];
                    break;
                case FurOptions.GREY:
                    obj.GetComponent<Renderer>().sharedMaterial = furColors[2];
                    break;
            }
        }

        /// <summary>
        /// Update Cat Eye Color
        /// </summary>
        /// <param name="eyeColor"></param>
        public void UpdateEyeColor(GameObject[] objects, EyeOptions eyeColor)
        {
            foreach (var obj in objects)
            {
                switch (eyeColor)
                {
                    case EyeOptions.BLUE:
                        obj.GetComponent<Renderer>().sharedMaterial = eyeColors[0];
                        break;
                    case EyeOptions.BROWN:
                        obj.GetComponent<Renderer>().sharedMaterial = eyeColors[1];
                        break;
                    case EyeOptions.GREEN:
                        obj.GetComponent<Renderer>().sharedMaterial = eyeColors[2];
                        break;
                }
            }
        }
    }
}
