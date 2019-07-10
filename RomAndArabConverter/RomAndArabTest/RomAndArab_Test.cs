using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomAndArabConverter;
namespace RomAndArabTest
{
    
    [TestClass]
    public class ARAB_To_ROM_Test
    {
        [TestMethod]
        public void Number_1_ToRom_Returns_I()
        {
            int input = 1;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("I", output);
        }

        [TestMethod]
        public void Number_3_ToRom_Returns_III()
        {
            int input = 3;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("III", output);

        }

        [TestMethod]
        public void Number_4_ToRom_Returns_IV()
        {
            int input = 4;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("IV", output);

        }

        [TestMethod]
        public void Number_5_ToRom_Returns_V()
        {
            int input = 5;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("V", output);
        }
       
        [TestMethod]
        public void Number_8_ToRom_Returns_VIII()
        {
            int input = 8;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("VIII", output);
        }

        [TestMethod]
        public void Number_9_ToRom_Returns_IX()
        {
            int input = 9;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("IX", output);
        }

        [TestMethod]
        public void Number_10_ToRom_Returns_X()
        {
            int input = 10;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("X", output);
        }

        [TestMethod]
        public void Number_11_ToRom_Returns_XI()
        {
            int input = 11;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("XI", output);
        }
        [TestMethod]
        public void Number_18_ToRom_Returns_XVIII()
        {
            int input = 18;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("XVIII", output);
        }
        [TestMethod]
        public void Number_20_ToRom_Returns_XX()
        {
            int input = 20;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("XX", output);
        }

        [TestMethod]
        public void Number_26_ToRom_Returns_XXVI()
        {
            int input = 26;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("XXVI", output);
        }

        [TestMethod]
        public void Number_35_ToRom_Returns_XXXV()
        {
            int input = 35;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("XXXV", output);
        }

        [TestMethod]
        public void Number_45_ToRom_Returns_XLV()
        {
            int input = 45;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("XLV", output);
        }
        [TestMethod]
        public void Number_50_ToRom_Returns_L()
        {
            int input = 50;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("L", output);
        }
        [TestMethod]
        public void SNumber_68_ToRom_Returns_LXVIII()
        {
            int input = 68;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("LXVIII", output);
        }
        [TestMethod]
        public void Number_77_ToRom_Returns_LXXVII()
        {
            int input = 77;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("LXXVII", output);
        }

        [TestMethod]
        public void Number_88_ToRom_Returns_LXXXVIII()
        {
            int input = 88;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("LXXXVIII", output);
        }

        [TestMethod]
        public void Number_93_ToRom_Returns_XCIII()
        {
            int input = 93;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("XCIII", output);
        }

        [TestMethod]
        public void Number_100_ToRom_Returns_C()
        {
            int input = 100;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("C", output);
        }

        [TestMethod]
        public void Number_136_ToRom_Returns_CXXXVI()
        {
            int input = 136;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("CXXXVI", output);
        }

        [TestMethod]
        public void Number_245_ToRom_Returns_CCXLV()
        {
            int input = 245;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("CCXLV", output);
        }

        [TestMethod]
        public void Number_375_ToRom_Returns_CCCLXXV()
        {
            int input = 375;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("CCCLXXV", output);
        }

        [TestMethod]
        public void Number_435_ToRom_Returns_CDXXXV()
        {
            int input = 435;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("CDXXXV", output);
        }


        [TestMethod]
        public void Number_544_ToRom_Returns_DXLIV()
        {
            int input = 544;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("DXLIV", output);
        }

        [TestMethod]
        public void Number_628_ToRom_Returns_DCXXVIII()
        {
            int input = 628;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("DCXXVIII", output);
        }

        [TestMethod]
        public void Number_733_ToRom_Returns_DCCXXXIII()
        {
            int input = 733;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("DCCXXXIII", output);
        }

        [TestMethod]
        public void Number_832_ToRom_Returns_DCCCXXXII()
        {
            int input = 832;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("DCCCXXXII", output);
        }

        [TestMethod]
        public void Number_952_ToRom_Returns_CMLII()
        {
            int input = 952;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("CMLII", output);
        }

        [TestMethod]
        public void Number_999_ToRom_Returns_CMXCIX()
        {
            int input = 999;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("CMXCIX", output);
        }

        [TestMethod]
        public void Number_1246_ToRom_Returns_MCCXLVI()
        {
            int input = 1246;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("MCCXLVI", output);
        }

        [TestMethod]
        public void Number_2578_ToRom_Returns_MMDLXXVIII()
        {
            int input = 2578;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("MMDLXXVIII", output);
        }

        [TestMethod]
        public void Number_3584_ToRom_Returns_MMMDLXXXIV()
        {
            int input = 3584;

            string output = Converter.ConvertToRom(input);

            Assert.AreEqual("MMMDLXXXIV", output);
        }

    }

    [TestClass]
    public class ROM_To_ARAB_Test {

        [TestMethod]
        public void Number_I_ToArab_Returns_1()
        {
            string input = "I";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void Number_III_ToArab_Returns_3()
        {
            string input = "III";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(3, output);
        }

        [TestMethod]
        public void Number_IV_ToArab_Returns_4()
        {
            string input = "IV";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(4, output);
        }

        [TestMethod]
        public void Number_VIII_ToArab_Returns_8()
        {
            string input = "VIII";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(8, output);
        }

        [TestMethod]
        public void Number_IX_ToArab_Returns_9()
        {
            string input = "IX";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(9, output);
        }

        [TestMethod]
        public void Number_X_ToArab_Returns_10()
        {
            string input = "X";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(10, output);
        }

        [TestMethod]
        public void Number_XI_ToArab_Returns_11()
        {
            string input = "XI";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(11, output);
        }

        [TestMethod]
        public void Number_XV_ToArab_Returns_15()
        {
            string input = "XV";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(15, output);
        }

        [TestMethod]
        public void Number_XX_ToArab_Returns_20()
        {
            string input = "XX";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(20, output);
        }

        [TestMethod]
        public void Number_XXV_ToArab_Returns_25()
        {
            string input = "XXV";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(25, output);
        }


        [TestMethod]
        public void Number_XXXIII_ToArab_Returns_33()
        {
            string input = "XXXIII";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(33, output);
        }


        [TestMethod]
        public void Number_XLV_ToArab_Returns_45()
        {
            string input = "XLV";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(45, output);
        }

        [TestMethod]
        public void Number_LXXVII_ToArab_Returns_77()
        {
            string input = "LXXVII";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(77, output);
        }

        [TestMethod]
        public void Number_XCVIII_ToArab_Returns_98()
        {
            string input = "XCVIII";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(98, output);
        }

        [TestMethod]
        public void Number_CXX_ToArab_Returns_120()
        {
            string input = "CXX";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(120, output);
        }

        [TestMethod]
        public void Number_CCXXIV_ToArab_Returns_224()
        {
            string input = "CCXXIV";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(224, output);
        }

        [TestMethod]
        public void Number_CCCXXXV_ToArab_Returns_335()
        {
            string input = "CCCXXXV";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(335, output);
        }

        [TestMethod]
        public void Number_CDXLVII_ToArab_Returns_447()
        {
            string input = "CDXLVII";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(447, output);
        }

        [TestMethod]
        public void Number_DII_ToArab_Returns_502()
        {
            string input = "DII";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(502, output);
        }
        [TestMethod]
        public void Number_DCXVII_ToArab_Returns_617()
        {
            string input = "DCXVII";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(617, output);
        }
        [TestMethod]
        public void Number_DCCXXXII_ToArab_Returns_732()
        {
            string input = "DCCXXXII";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(732, output);
        }
        [TestMethod]
        public void Number_DCCCLII_ToArab_Returns_852()
        {
            string input = "DCCCLII";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(852, output);
        }
        [TestMethod]
        public void Number_CML_ToArab_Returns_950()
        {
            string input = "CML";

            int output = Converter.ConvertToArab(input);

            Assert.AreEqual(950, output);
        }
    }


    [TestClass]
    public class Converter_Test {


        [TestMethod]
        public void WrongFormat_ARABtoROM_Returns_FormatError()
        {
            string input = "14|ARA|ROM";

            string output = Converter.LineOutcome(input);

            Assert.AreEqual("Invalid Format",output);
        }

        [TestMethod]
        public void RightFormat_ARABToROMReturns_Line()
        {
            string input = "14|ARAB|ROM";

            string output = Converter.LineOutcome(input);

            Assert.AreEqual("14|ARAB|ROM|XIV", output);
        }
        [TestMethod]
        public void NumberOutOftheRange_Returns_ErrorRange()
        {
            string input = "4000|ARAB|ROM";

            string output = Converter.LineOutcome(input);

            Assert.AreEqual("ARAB number is out of range, number must be between 1 and 3999" ,output);
        }

        [TestMethod]
        public void WrongFormat_ROMtoARAB_Returns_FormatError()
        {
            string input = "VII|ROM|AB";

            string output = Converter.LineOutcome(input);

            Assert.AreEqual("Invalid Format", output);
        }

        [TestMethod]
        public void InvalidARABNumber_Returns_InvalidNumberMessage()
        {
            string input = "1.5r|ARAB|ROM";

            string output = Converter.LineOutcome(input);

            Assert.AreEqual("Number Invalid, number must not have symbols or letters", output);
        }

        [TestMethod]
        public void InvalidROMNumber_Returns_InvalidNumberMessage()
        {
            string input = "XLQ|ROM|ARAB";

            string output = Converter.LineOutcome(input);

            Assert.AreEqual("Invalid Roman number, number must not have any letter besides (I,V,X,L,C,D,M)", output);
        }

        [TestMethod]
        public void NoRulesNumber_XXC_ToArab_Returns_ErroMessage()
        {
            string input = "XXC|ROM|ARAB";

            string output = Converter.LineOutcome(input);

            Assert.AreEqual("Roman numbers' rules were not followed", output);
        }
        [TestMethod]
        public void L_ToArab_Returns_50()
        {
            string input = "l|rom|arab";

            string output = Converter.LineOutcome(input);

            Assert.AreEqual("L|ROM|ARAB|50", output);
        }

        [TestMethod]
        public void MMMM_ToArab_Returns_MessageError()
        {
            string input = "MMMM|rom|arab";

            string output = Converter.LineOutcome(input);

            Assert.AreEqual("ROM number is out of range, number must be between I and MMMCMXCIX", output);
        }
    }


}
