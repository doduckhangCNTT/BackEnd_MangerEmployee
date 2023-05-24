namespace MISA.WebFresher032023.Demo
{
    public class Caculator
    {
        /// <summary>
        /// Ham cong 2 so nguyen
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// Created By: DDKhang(5/5/2023)
        public long Add(int a, int b)
        {
            return a + (long)b;
        }

        /// <summary>
        /// Ham tru 2 so nguyen
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// Created By: DDKhang(5/5/2023)
        public long Sub(int a, int b)
        {
            return a - (long)b;
        }

        /// <summary>
        /// Hàm nhân 2 số
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long Mul(int a, int b)
        {
            return a * (long)b;
        }

        /// <summary>
        /// Hàm chia 2 số
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double Div(int a, int b)
        {
            if(b == 0)
            {
                throw new Exception("Khong chia duoc");
            }
            return (double)a / b;
        }
    }
}
