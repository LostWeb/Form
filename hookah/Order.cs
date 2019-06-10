using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hookah
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Крепость кальяна
        /// </summary>
        public Strength Strength { get; set; }
        /// <summary>
        /// Вид табака
        /// </summary>
        public Tobaco Tobaco { get; set; }
        /// <summary>
        /// Способ забивки кальяна
        /// </summary>
        public Type Type { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Кальянщик
        /// </summary>
        public Employee Employee { get; set; }

        public override string ToString()
        {
            return "#Заказ: Крепость - " + GetStringStrength(Strength) + "; Табак - " + GetStringTobaco(Tobaco) +
                "; Способ забивки - " + GetTypeString(Type) + "; Цена: " + Price.ToString() + " руб.";
        }

        private string GetTypeString(Type info)
        {
            switch (info)
            {
                case Type.milk:
                    return "На молоке";
                case Type.fruits:
                    return "С фруктами";
                case Type.mint:
                    return "С мятой и льдом";
                default:
                    throw new Exception();
            }
        }

        private string GetStringTobaco(Tobaco info)
        {
            switch (info)
            {
                case Tobaco.ALFAKHER:
                    return "ALFAKHER";
                case Tobaco.NAKHLA:
                    return "NAKHLA";
                case Tobaco.AFZAL:
                    return "AFZAL";
                case Tobaco.ADALYA:
                    return "ADALYA";
                case Tobaco.SERBETLI:
                    return "SERBETLI";
                case Tobaco.DARKSIDE:
                    return "DARKSIDE";
                case Tobaco.TANGIERS:
                    return "TANGIERS";
                default:
                    throw new Exception();
            }
        }

        private string GetStringStrength(Strength info)
        {
            switch (info)
            {
                case Strength.light:
                    return "Лёгкая";
                case Strength.middle:
                    return "Средняя";
                case Strength.heavy:
                    return "Тяжёлая";
                default:
                    throw new Exception();
            }
        }
    }

    public enum Strength { light, middle, heavy }
    public enum Tobaco { ALFAKHER, NAKHLA, AFZAL, ADALYA, SERBETLI, DARKSIDE, TANGIERS }
    public enum Type { milk, fruits, mint }
}
