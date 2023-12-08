using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_4OTIRE
{
    internal class Komputar
    {
        
            string model;
            int frequency;
            string gpu;
            int hdd;
            int ram;
            int price;
            public Komputar(string model, int frequency, string gpu, int hdd, int ram, int price)
            {
                this.model = model;
                this.frequency = frequency;
                this.gpu = gpu;
                this.hdd = hdd;
                this.ram = ram;
                this.price = price;
            }
            public string GetInformation()
            {
                string information;
                information = "Модель: " + this.model + "; Тактовая частота: " + this.frequency.ToString() + "; Марка видеокарты: " + this.gpu +
                    "; Объём жёсткого диска: " + this.hdd.ToString() + "; Объём опреативной памяти: " + this.ram.ToString() + "; Стоимость: " + this.price.ToString();

                return information;
            }
        }
    }


