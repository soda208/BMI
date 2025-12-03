using System;

public class BmiCalculatorSimple
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Simple BMI Calculator ---");
        
        // 1. รับค่าน้ำหนัก (Weight)
        Console.Write("Enter weight in kilograms (kg): ");
        // ใช้ double.Parse เพื่อแปลง input เป็นตัวเลข โดยถือว่า input ถูกต้อง
        double weightKg = double.Parse(Console.ReadLine());
        
        // 2. รับค่าส่วนสูง (Height)
        Console.Write("Enter height in meters (m): ");
        double heightM = double.Parse(Console.ReadLine());

        // 3. คำนวณ BMI
        // Formula: weight (kg) / [height (m)]^2
        double bmi = weightKg / (heightM * heightM);

        // 4. แสดงผลลัพธ์
        Console.WriteLine($"\nYour calculated BMI is: {bmi:F2}");

        // 5. แปลผล (Classification)
        string classification;
        
        if (bmi < 18.5)
        {
            classification = "Underweight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            classification = "Normal weight";
        }
        else if (bmi >= 25.0 && bmi <= 29.9)
        {
            classification = "Overweight";
        }
        else if (bmi >= 30.0 && bmi <= 34.9)
        {
            classification = "Obesity Class I (Moderate)";
        }
        else if (bmi >= 35.0 && bmi <= 39.9)
        {
            classification = "Obesity Class II (Severe)";
        }
        else
        {
            classification = "Obesity Class III (Very Severe)";
        }

        Console.WriteLine($"Classification: {classification}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
