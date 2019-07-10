using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomAndArabConverter
{


    public class Converter
    {
        private static string[] ReadFile(string fileUrl)
        {
            string[] lines = System.IO.File.ReadAllLines(@fileUrl);
            return lines;
        }

        public void Outcomes(string URL, string OutURL) {
            string[] lines = ReadFile(URL);
            string[] NewFile = new string[lines.Length];
            StreamWriter writer = new StreamWriter(OutURL + "\\Output.txt");

           
            for (int i = 0; i <lines.Length; i++)
            {
                writer.Write(LineOutcome(lines[i]) +"\n");
            }
            writer.Close();
        }

        internal static bool IsAValidNumber(string input)
        {
            bool IsValid = int.TryParse(input, out int a);
            return IsValid;
        }

        internal static bool IsAValidRoman(string input) {

            char[] Letters = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            foreach (char letter in input)
            {
                if (!Letters.Contains<char>(letter))
                    return false;
            }
            return true;

        }

        public static string LineOutcome(string input)
        {
            string[] arr = input.Split('|');

            if (arr.Length != 3)
                return "Invalid Format";

            arr[1] = arr[1].ToUpper();
            arr[2] = arr[2].ToUpper();

            string result = "";

            if (arr[1] == "ARAB")
            {
                if (arr[2] == "ROM")
                {
                    //Arab to Rom
                    if (IsAValidNumber(arr[0]))
                    {
                        int ARAbNum = Convert.ToInt32(arr[0]);
                        if (ARAbNum > 0 && ARAbNum < 4000)
                        {
                            result = ConvertToRom(ARAbNum);
                        }
                        else {
                            return "ARAB number is out of range, number must be between 1 and 3999";
                        }
                    }
                    else {
                        return "Number Invalid, number must not have symbols or letters";
                    }
                }
                else {
                    return "Invalid Format";
                }
            }
            else if (arr[1] == "ROM")
            {
                if (arr[2] == "ARAB")
                {
                    arr[0] = arr[0].ToUpper();
                    //RomToArab

                    if (IsAValidRoman(arr[0]))
                    {
                        result = ConvertToArab(arr[0]).ToString();
                        int resu = Convert.ToInt32(result);

                        if (resu > 0 && resu < 4000)
                        {
                            if (arr[0] != Converter.ConvertToRom(resu).ToString())
                            {
                                return "Roman numbers' rules were not followed";
                            }
                        }
                        else
                        {
                            return "ROM number is out of range, number must be between I and MMMCMXCIX";
                        }

                    }
                    else {
                        return "Invalid Roman number, number must not have any letter besides (I,V,X,L,C,D,M)";
                    }
                }
                else
                {
                    return "Invalid Format";
                }
            }
            else {
                return "Invalid Format";
            }
            string line = arr[0] + "|" + arr[1] + "|" + arr[2] + "|" + result;
            return line;
        }
        
        public static string ConvertToRom(int input)
        {
             ARAB_To_ROM ToRom = new ARAB_To_ROM();
             return ToRom.ConvertToRom(input);
            
           
        }
        public static int ConvertToArab(string input)
        {
            ROM_To_ARAB ToArab = new ROM_To_ARAB();
            return ToArab.ConvertToArab(input);
        }

       
    }

    public class ARAB_To_ROM
    {
        private static string[] Letters = { "I", "V", "X", "L", "C", "D", "M" };
        private static int[] Values = { 1, 5, 10, 50, 100, 500, 1000 };

        internal string ConvertToRom(int input)
        {
           string Roman = "";

            if (input <= 10)
            {
                Roman = OneNumber(input);
            }
            else if (input < 100)
            {
                Roman = TwoNumbers(input);
            }
            else if (input < 1000)
            {
                Roman = ThreeNumbers(input);
            }
            else {
                Roman = FourNumbers(input);
            }
            return Roman;
        }
        private string OneNumber(int input)
        {
            if (input == 0)
                return "";

            string Roman = "";
            if (input <= 3)
            {
                input--;
                Roman = Letters[0] + OneNumber(input);
            }
            else if (input == 4)
            {
                Roman = Letters[0] + Letters[1];
            }
            else if (input >= 5 && input <= 8)
            {
                input -= Values[1];
                Roman = Letters[1] + OneNumber(input);
                return Roman;
            }
            else if (input == 9) {
                Roman = Letters[0] + Letters[2];
            }
            else
            {
                Roman = Letters[2];
            }
            return Roman;
        }
        private string TwoNumbers(int input)
        {
            if (input == 0)
                return "";

            string Roman = "";
            if (input < 40)
            {
                while (input >= 10)
                {
                    Roman += Letters[2];
                    input -= Values[2];
                }
                Roman += OneNumber(input);
            }
            else if (input < 50)
            {
                Roman = Letters[2] + Letters[3] + OneNumber(input - 40);
            }
            else if (input < 90)
            {
                input -= Values[3];
                Roman = Letters[3] + TwoNumbers(input);
            }
            else {
                Roman = Letters[2] + Letters[4] + OneNumber(input - 90); 
            }
            return Roman;
        }
        private string ThreeNumbers(int input)
        {
            string Roman = "";

            if (input < 400)
            {
                while (input >= 100)
                {
                    Roman += Letters[4];
                    input -= Values[4];
                }
                Roman += TwoNumbers(input);
            }
            else if (input < 500)
            {
                Roman = Letters[4] + Letters[5] + TwoNumbers(input - 400);
            }
            else if (input < 900) {
                input -= Values[5];
                Roman = Letters[5] + ThreeNumbers(input);
            }
            else
            {
                Roman = Letters[4] + Letters[6] + TwoNumbers(input - 900);
            }
            return Roman;
        }
        private string FourNumbers(int input)
        {
            string Roman = "";

            while (input >= 1000) {
                Roman += Letters[6];
                input -= Values[6];

            }
            Roman += ThreeNumbers(input);
            return Roman;
        }
    }
    class ROM_To_ARAB {

        private static int Identify_char(char letter)
        {
            int num;
            if (letter == 'I')
            {
                num = 1;
            }
            else if (letter == 'V')
            {
                num = 5;
            }
            else if (letter == 'X')
            {
                num = 10;
            }
            else if (letter == 'L')
            {
                num = 50;
            }
            else if (letter == 'C')
            {
                num = 100;
            }
            else if (letter == 'D')
            {
                num = 500;
            }
            else if (letter == 'M')
            {
                num = 1000;
            }
            else
            {
                // char incorrecto
                num = -1;

            }
            return num;
        }

        internal int ConvertToArab(string input)
        {

            int Arab = 0;
            int lenghtt = input.Length;

            if (lenghtt == 1)
            {
                char cha = (char)input[0];

                return Identify_char(cha);
            }
            int i = 0;
            while (i < lenghtt)
            {
                char cha1 = (char)input[i];

                if (lenghtt - i > 1)
                {
                    char cha2 = (char)input[i + 1];
                    if (Identify_char(cha1) == -1 || Identify_char(cha2) == -1)
                    {
                        return -1;
                    }
                    else if (Identify_char(cha1) < Identify_char(cha2))
                    {
                        Arab += Identify_char(cha2) - Identify_char(cha1);
                        i += 2;
                    }
                    else
                    {
                        Arab += Identify_char(cha1);
                        i++;
                    }
                }

                else
                {
                    Arab += Identify_char(cha1);
                    i++;
                }
            }
            return Arab;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();

           
            Console.Write("Type input file location URL: ");
            string URL1 = Console.ReadLine();
            Console.Write("Type were you want the output file,  location URL: ");
            string URL2 = Console.ReadLine();
            // escribir que esta listo y que si falla diga algog como que huno un error con los urls que los cheequee 
            try
            {
                converter.Outcomes(URL1, URL2);
                Console.Clear();
                Console.WriteLine("Done...");
                Console.ReadKey();
            }
            catch {
                Console.WriteLine("Something was wrong, please check the URLs and try again");
                Console.ReadKey();
            }
        }
    }
}
