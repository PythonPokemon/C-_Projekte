using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {
        // Membervariablen
        private string color = "weiß";
        // Länge
        int length;
        // Höhe
        //int height;
        // Breite
        int width;
        // Volumen
        int volume;

        // auto - implemented property // prop + 2Mal Tab
        public int Height { get; set; }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.Height = height;
            this.width = width;
        }

        // write only
        public int Volume
        {
            get
            {
                return Height * Length * Width;
            }

            set
            {
                volume = value;
            }
        }

        // Nur lesen - read only
        public int Width
        {
            get
            {
                return width;
            }
            /*
            set
            {
                if (value < 0)
                {
                    value = -value;
                }
                width = value;
            }
            */
        }

        public int Length
        {
            get => length;
            set => length = value;
        }
        /*
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        */
        /*
        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }
        */

        public int FrontSurface
        {
            get
            {
                return Height * length;
            }

        }

        public void DisplayInfo()
        {
            Console.WriteLine("Länge ist {0} und Höhe ist {1} und Breite ist {2} somit ist das Volumen {3}",
                length, Height, width, volume = length * Height * width);
        }


    }
}
