namespace PTPMQL.Models
{
    public class Bai3
    {
        public double Height { get; set; }
        public double Weight { get; set; }   
        public double CalculateBMI()
        {
            if (Height <= 0) return 0;
            return Weight / (Height * Height);
        }

        public string GetCategory()
        {
            double bmi = CalculateBMI();
            if (bmi == 0) return "Dữ liệu không hợp lệ";
            if (bmi < 18.5) return "Gầy";
            else if (bmi < 24.9) return "Bình thường";
            else if (bmi < 29.9) return "Thừa cân";
            else return "Béo phì";
        }
    }
}