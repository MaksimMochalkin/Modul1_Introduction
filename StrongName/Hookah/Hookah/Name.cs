using System;

namespace Hookah
{
    public class Name
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        
        public string GetModel(string model)
        {
            Model = model;
            return String.Format("Модель данного кальяна: {0}", model);
        }

        public string TypeHookah(string type)
        {
            Type = type;
            return String.Format("Тип данного кальяна: {0}", type);
        }

        public string MaterialHookah(string material)
        {
            Material = material;
            return String.Format("Материал изготовления: {0}", material);
        }
    }
}
