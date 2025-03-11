using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL_4
{


    public enum Mode1 { QueitTurbo, QueitBalance, QueitPerformance };
    public enum kegiatan { fanTurbo, fanBalance, fanPerformance };
    internal class FanLaptop
    {
        private Mode1 state;

        public FanLaptop()
        {
            state = Mode1.QueitTurbo;
            state = Mode1.QueitBalance;
            state = Mode1.QueitPerformance;
        }

        public void UbahStateFan(kegiatan opsi)
        {
            switch (state)
            {
                case Mode1.QueitTurbo:
                    if (opsi == kegiatan.fanTurbo)
                    {
                        Console.WriteLine("Turbo");
                        state = Mode1.QueitTurbo;
                    }
                    else
                    {
                        Console.WriteLine("Fan Queit menjadi Turbo");
                    }
                    break;

                case Mode1.QueitBalance:
                    if (opsi == kegiatan.fanBalance)
                    {
                        Console.WriteLine("balance");
                        state = Mode1.QueitBalance;
                    }
                    else
                    {
                        Console.WriteLine("Fan Queit menjadi balance");
                    }
                    break;
                case Mode1.QueitPerformance:
                    if (opsi == kegiatan.fanPerformance)
                    {
                        Console.WriteLine("performance");
                        state = Mode1.QueitPerformance;
                    }
                    else
                    {
                        Console.WriteLine("Fan Queit menjadi Performance");
                    }
                    break;

            }
        }

        public void getFanLaptop()
        {
            Console.WriteLine("Status Fan: " + state);
        }

        internal void ubahStateFan(MODUL_4.kegiatan trigger)
        {
            throw new NotImplementedException();
        }

        internal void UbahStateFan(MODUL_4.kegiatan trigger)
        {
            throw new NotImplementedException();
        }

        public class kegiatan
        {
            internal static kegiatan fanTurbo;
            internal static kegiatan fanBalance;
            internal static kegiatan fanPerformance;
        }
    }
}


