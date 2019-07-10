# ROM-and-ARAB-Converter
The program converts numbers from ROM to ARAB and the other way around.
This program was coded in C#. It also has an unit test included.
In this program you need to enter a .txt file that will have the input you will like to enter. 
The input file will have several lines and there is a format that must be separated by '|'

The input format format per line will be:
Value|Format of the value|Format requested

An example of an input should be:

10|ARAB|ROM

8|ARAB|ROM

CMXCIX|ROM|ARAB

MMCCCXCVII|ROM|ARAB


After that, you will get another file .txt called output.txt this file will have all the lines with their output.

The output format per line will be:
Value|Format of the value|Format requested| Value converted

The output of the previous example is:


10|ARAB|ROM|X

8|ARAB|ROM|VIII

CMXCIX|ROM|ARAB|999

MMCCCXCVII|ROM|ARAB|2397


The program is not case sensitive, so if it is typed "rom" the program will read it perfectly.

When the program starts, it is going to ask you for the URL of the input file(.txt). And after that, it is going to ask you for the URL where you want the output.txt to be located.

List of message error

- It is very important to write the words "ARAB" and "ROM" completely, because if it is missed any letter or it is typed incorrectly. An  error message that says "Invalid Format" will be displayed on that line. 

- ARAB numbers must be only numbers, because if there is any symbol or letter, an error message that says "Number Invalid, number must not have symbols or letters" will be displayed on that line. 

- ROM numbers must be only Roman numbers, because if it is typed a letter that it is not a ROM letter, an error message that says "Invalid Roman number, number must not have any letter besides (I,V,X,L,C,D,M)" will be displayed on that line. 

- ARAB number must be between 1 and 3999, if not, an error message that says "ARAB number is out of range, number must be between 1 and 3999" will be displayed on that line. 

- ROM numbers must be between I and MMMCMXCIX, if not, an error that says "ROM number is out of range, number must be between I and MMMCMXCIX" will be displayed on that line.

- Make sure you follow Roman numbers' rules, because if you try to convert "IIII" instead of "IV", an error message that says "Roman numbers' rules were not followed" will be displayed on that line.

- In Case the URLs are incorrect, an error message that says "Something was wrong, please check the URLs and try again" will be displayed on the screen. 
