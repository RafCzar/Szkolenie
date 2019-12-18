using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03___Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            string /*typ danych*/ zmienna /*nazwa zmiennej*/ = "jakis text";
            zmienna = "jakis text";

            //LICZBY CALKOWITE

            byte vByte = 255;
            Console.WriteLine($"zmienna vByte - [ {vByte} ]");
            Console.WriteLine($"min: [ {Byte.MinValue} ] max: [ {Byte.MaxValue} ]");

            sbyte vSbyte = 100;
            Console.WriteLine($"zmienna vSbyte - [ {vSbyte} ]");
            Console.WriteLine($"min: [ {SByte.MinValue} ] max: [ {SByte.MaxValue} ]");

            short vShort = 100;
            Console.WriteLine($"zmienna vShort - [ {vShort} ]");
            Console.WriteLine($"min: [ {Int16.MinValue} ] max: [ {Int16.MaxValue} ]");

            ushort vUshort = 100;
            Console.WriteLine($"zmienna vUshort - [ {vUshort} ]");
            Console.WriteLine($"min: [ {UInt16.MinValue} ] max: [ {UInt16.MaxValue} ]");

            int vInt = 100;
            Console.WriteLine($"zmienna vInt - [ {vInt} ]");
            Console.WriteLine($"min: [ {Int32.MinValue} ] max: [ {Int32.MaxValue} ]");

            uint vUint = 100;
            Console.WriteLine($"zmienna vUint - [ {vUint} ]");
            Console.WriteLine($"min: [ {UInt32.MinValue} ] max: [ {UInt32.MaxValue} ]");

            long vLong = 100;
            Console.WriteLine($"zmienna vLong - [ {vLong} ]");
            Console.WriteLine($"min: [ {Int64.MinValue} ] max: [ {Int64.MaxValue} ]");

            ulong vUlong = 100;
            Console.WriteLine($"zmienna vUlong - [ {vUlong} ]");
            Console.WriteLine($"min: [ {UInt64.MinValue} ] max: [ {UInt64.MaxValue} ]");

            //LICZBY ZMIENNOPRZECINKOWE

            float vFloat = 1.5f;
            Console.WriteLine($"zmienna vFloat - [ {vFloat} ]");
            Console.WriteLine($"min: [ {Single.MinValue} ] max: [ {Single.MaxValue} ]");

            double vDouble = 1.5;
            Console.WriteLine($"zmienna vDouble - [ {vDouble} ]");
            Console.WriteLine($"min: [ {Double.MinValue} ] max: [ {Double.MaxValue} ]");

            decimal vDecimal = 1.55555M;
            Console.WriteLine($"zmienna vDecimal - [ {vDecimal} ]");
            Console.WriteLine($"min: [ {Decimal.MinValue} ] max: [ {Decimal.MaxValue} ]");

            //BOOLEAN

            bool vBool = true;
            Console.WriteLine($"zmienna vBool - [ {vBool} ]");
            vBool = false;
            Console.WriteLine($"zmienna vBool - [ {vBool} ]");

            //NULLABLE

            int? zmiennaNulla = null;
            Console.WriteLine($"zmienna zmiennaNulla - [ {zmiennaNulla} ]");

            //TYP ZNAKOWY

            char vChar = 'a';
            Console.WriteLine($"zmienna vChar - [ {vChar} ]");

            //LANUCH ZNAKOW

            string vImie = "Jan";
            string vNazwisko = "   Kowalski   ";
            Console.WriteLine($"{vImie} {vNazwisko}");
            Console.WriteLine($"{vImie.ToUpper()} {vNazwisko.ToLower()}");
            Console.WriteLine($"{vImie.Trim()} {vNazwisko.Trim()}");
            Console.WriteLine($"{vImie} {vNazwisko.Substring(2,3)}");

            Console.WriteLine("d:\\moje_pliki\\plik.txt");

            Console.WriteLine($@"d:\moje_pliki\plik.txt");

            //VAR

            var vZmienna = "abc";
            Console.WriteLine(vZmienna);
            Console.WriteLine(vZmienna.GetType());

            var vVarInt = 22;
            Console.WriteLine(vVarInt.GetType());

            var vVarFloat = 22f;
            Console.WriteLine(vVarFloat.GetType());

            //DYNAMIC

            dynamic dynamicInt;

            dynamicInt = 12;
            Console.WriteLine(dynamicInt);
            Console.WriteLine(dynamicInt.GetType());

            dynamicInt = "agc";
            Console.WriteLine(dynamicInt);
            Console.WriteLine(dynamicInt.GetType());

            //OBJECT

            object vObject = 0;
            Console.WriteLine(vObject);
            Console.WriteLine(vObject.GetType());
            vObject = "abc";
            Console.WriteLine(vObject);
            Console.WriteLine(vObject.GetType());

            //DATA

            Console.WriteLine($"teraz: [ {DateTime.Now} ]");
            Console.WriteLine($"dziś: [ {DateTime.Today} ]");
            Console.WriteLine($"wczoraj: [ {DateTime.Today.AddDays(-1)} ]");
            Console.WriteLine($"jutro: [ {DateTime.Today.AddDays(1)} ]");
            Console.WriteLine($"dzień roku: [ {DateTime.Today.DayOfYear} ]");
            Console.WriteLine($"dzień roku: [ {DateTime.UtcNow} ]");

            DateTime jakasData = DateTime.Now;
            Console.WriteLine(jakasData);

            DateTime jakasDataUtc = DateTime.UtcNow;
            Console.WriteLine(jakasDataUtc);

            Console.WriteLine(jakasDataUtc.ToLocalTime());

            DateTime zmiennaDateTime = new DateTime(2017, 04, 02);
            Console.WriteLine(zmiennaDateTime);

            Console.ReadKey();
        }
    }
}
