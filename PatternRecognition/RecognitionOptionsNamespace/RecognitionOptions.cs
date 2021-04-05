using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition.RecognitionOptionsNamespace
{
    /// <summary>
    /// 
    /// Класс настройки процесса распознавания фигур на изображении.
    /// 
    /// ВАЖНО: Если вы иницилиализируете свойства объекта данного класса или его потомков,
    /// то всегда производите это в следующем порядке:
    /// COLOUR,
    /// ColourFunc,
    /// DifBeetwinColours.
    /// 
    /// </summary>
    public class RecognitionOptions
    {
        protected Type _COLOUR;
        public virtual Type COLOUR
        {
            get => _COLOUR;
            set
            {
                _COLOUR = value;
                _ColourFunc = null;
                _DifBeetwinColours = null;
            }
        }


        protected MulticastDelegate _ColourFunc;
        public virtual MulticastDelegate ColourFunc
        {
            get => _ColourFunc;
            set => _ColourFunc = value;
        }


        protected MulticastDelegate _DifBeetwinColours;
        public virtual MulticastDelegate DifBeetwinColours
        {
            get => _DifBeetwinColours;
            set => _DifBeetwinColours = value;
        }


        protected MulticastDelegate _WhichPixelUnionWith;
        public virtual MulticastDelegate WhichPixelUnionWith
        {
            get => _WhichPixelUnionWith;
            set => _WhichPixelUnionWith = value;
        }


        public virtual bool NoiseSuppression { get; set; }
    }
}
