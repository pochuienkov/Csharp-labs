using System;
using System.Linq;

namespace csharp1
{

    class Program
    {
        enum Name
        {
            first,
            second,
            third,
            fourth
        }

        class DollarBill
        {
            public string name;
            public string surname;
            public string patronymic;
            public string number;
            public double balance;
            public struct DollarDep
            {
                public Name name_dep;
                public double year_dep;
                public double balance_dep;
                public DollarDep(Name a, double b, double c)
                {
                    name_dep = a;
                    year_dep = b;
                    balance_dep = c;
                }
            };

            public DollarBill(string name, string surname, string patronymic, string number, double balance)
            {
                this.name = name;
                this.surname = surname;
                this.patronymic = patronymic;
                this.number = number;
                this.balance = balance;
            }

            public DollarBill()
            {
            }

            public virtual void ToString()
            {
                Console.WriteLine($"{name} " + $"{surname} " + $"{patronymic} " + $"{number} " + $"{balance}");
            }
        }

        class TestPol : DollarBill
        {
            public TestPol()
            {
                name = "Test";
                surname = "Test1";
                patronymic = "Test2";
                number = "90909090";
                balance = 10101;
            }

            public override void ToString()
            {
                Console.WriteLine("TestPol is working!");
            }
        }

        static void Show(ref DollarBill.DollarDep[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("\nDeposit " + (i + 1) + ":");
                Console.WriteLine("Title: " + array[i].name_dep);
                Console.WriteLine("Percent: " + array[i].year_dep);
                Console.WriteLine("Balance: " + array[i].balance_dep);
            }
        }

        static int _Letter(string str)
        {
            if (str.All(char.IsLetter))
            {
                return 1;
            }
            else
            {
                Console.WriteLine("ERROR: используйте лишь буквы!");
                return 0;
            }

        }


        static int _Number(string str)
        {
            if (!str.All(char.IsNumber))
            {
                Console.WriteLine("ERROR: используйте цифры!");
                return 1;
            }
            if (str.Length < 8 || str.Length > 8)
            {
                Console.WriteLine("ERROR: введите 8 цифр!");
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static int _OneNumber(string str, int checker)
        {
            if (!str.All(char.IsNumber))
            {
                Console.WriteLine("ERROR: используйте цифры!");
                return 99999;
            }
            else
            {
                checker = Convert.ToInt32(str);
                return checker;
            }
        }

        static int Add(ref DollarBill.DollarDep[] array)
        {
            int checker = array.Length + 1;
            checker--;
            DollarBill.DollarDep[] newarray = new DollarBill.DollarDep[array.Length + 1];
            newarray[checker] = new DollarBill.DollarDep();
            newarray[checker].name_dep = Name.fourth;
            newarray[checker].year_dep = 5;
            Console.WriteLine("Сумма: ");
            newarray[checker].balance_dep = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < checker; i++)
                newarray[i] = array[i];
            for (int j = checker; j < array.Length; j++)
                newarray[j] = array[j];
            array = newarray;
            Console.WriteLine("\nДепозит добавлен!");
            Show(ref array);
            return 0;
        }

        static void Percs(ref DollarBill.DollarDep[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i].balance_dep += (array[i].balance_dep / 100 * array[i].year_dep);
            Show(ref array);
        }

        static void getdollar(ref DollarBill dollar)
        {
            Console.WriteLine("Выберите действие: \n1. Пополнить \n2. Снять");
            string _str = Console.ReadLine();
            int checker = 0;
            checker = _OneNumber(_str, checker);
            int dollars = 0;
            switch (checker)
            {
                case 1:
                    Console.WriteLine("Введите сумму: ");
                    _str = Console.ReadLine();
                    dollars = _OneNumber(_str, dollars);
                    if (dollars < 0)
                    {
                        Console.WriteLine("ERROR: Сумма не может быть меньше 0!");
                        break;
                    }
                    dollar.balance += dollars;
                    break;
                case 2:
                    Console.WriteLine("Введите сумму: ");
                    _str = Console.ReadLine();
                    dollars = _OneNumber(_str, dollars);
                    if (dollars > dollar.balance)
                    {
                        Console.WriteLine("ERROR: На счету недостаточно средств!");
                        break;
                    }
                    else
                    {
                        dollar.balance -= dollars;
                        break;
                    }
                default:
                    Console.WriteLine("ERROR: такой операции нет!");
                    break;
            }
        }

        static int Del(ref DollarBill.DollarDep[] array)
        {
            Show(ref array);
            Console.WriteLine("Номер депозита: ");
            string index = Console.ReadLine();
            int checker = 0;
            checker = _OneNumber(index, checker);
            if (checker <= 0)
            {
                Console.WriteLine("ERROR: некорректный номер депозита!");
                return 1;
            }
            if (checker > array.Length)
            {
                Console.WriteLine("ERROR: нет такого депозита!");
                return 1;
            }
            checker--;
            DollarBill.DollarDep[] newarray = new DollarBill.DollarDep[array.Length - 1];

            for (int i = 0; i < checker; i++)
                newarray[i] = array[i];

            for (int j = checker + 1; j < array.Length; j++)
                newarray[j - 1] = array[j];

            array = newarray;
            Console.WriteLine("\nДепозит закрыт!");
            Show(ref array);
            return 0;
        }

        static void mymoney(ref DollarBill.DollarDep[] array)
        {
            double money = 0;
            for (int i = 0; i < array.Length; i++)
            {
                money += array[i].balance_dep;
            }
            Console.WriteLine("Все деньги на депозитах: " + money);
        }

        static void Main(string[] args)
        {
            DollarBill Dollar = new DollarBill("name", "surname", "patronymic", "00000000", 0.111);
            
            DollarBill.DollarDep[] DollarDeps =
            {
                new DollarBill.DollarDep(Name.first, 2.5, 1000),
                new DollarBill.DollarDep(Name.second, 4, 2000),
                new DollarBill.DollarDep(Name.third, 10, 5000),
            };
            TestPol test = new TestPol();
            int checker = 1;
            string _str;
            string str_check;

            do
            {
                checker = 0;
                Console.WriteLine("Введите фамилию:");
                str_check = Console.ReadLine();
                if (String.IsNullOrEmpty(str_check) || String.IsNullOrWhiteSpace(str_check)) { checker = 0; 
                Console.WriteLine("ERROR: ФИО не может быть пустым!");}
                
                else
                {
                    Dollar.surname = str_check;
                    checker = _Letter(Dollar.surname);
                }

                } while (checker != 1);
            do
            {
                checker = 0;
                Console.WriteLine("\nВведите имя:");
                
                str_check = Console.ReadLine();
                if (String.IsNullOrEmpty(str_check) || String.IsNullOrWhiteSpace(str_check)) { checker = 0;
                    Console.WriteLine("ERROR: ФИО не может быть пустым!");
                }
                else
                {
                    Dollar.name = str_check;
                    checker = _Letter(Dollar.name);
                }

            } while (checker != 1);
            do
            {
                checker = 0;
                Console.WriteLine("\nВведите отчество:");
                str_check = Console.ReadLine();
                if (String.IsNullOrEmpty(str_check) || String.IsNullOrWhiteSpace(str_check)) { checker = 0;
                    Console.WriteLine("ERROR: ФИО не может быть пустым!");
                }
                else
                {
                    Dollar.patronymic = str_check;
                    checker = _Letter(Dollar.patronymic);
                }
            } while (checker != 1);
            do
            {
                checker = 0;
                Console.WriteLine("\nВведите номер счета:");
                Dollar.number = Console.ReadLine();
                checker = _Number(Dollar.number);
            } while (checker != 0);
            do
            {
                checker = 0;
                Console.WriteLine("\n" + Dollar.name + " " + Dollar.surname + " " + Dollar.patronymic);
                Console.WriteLine("Счет номер " + Dollar.number + "\nНа счету: " + Dollar.balance);
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1. Открыть депозит \n2. Насчитать процент");
                Console.WriteLine("3. Пополнить баланс/снять деньги \n4. Закрыть депозит");
                Console.WriteLine("5. Общая сумма на депозитах \n6. ToString() \n7. Exit");
                _str = Console.ReadLine();
                checker = _OneNumber(_str, checker);
                switch (checker)
                {
                    case 1:
                        Add(ref DollarDeps);
                        break;
                    case 2:
                        Percs(ref DollarDeps);
                        break;
                    case 3:
                        getdollar(ref Dollar);
                        break;
                    case 4:
                        Del(ref DollarDeps);
                        break;
                    case 5:
                        mymoney(ref DollarDeps);
                        break;
                    case 6:
                        Console.WriteLine("\n");
                        Dollar.ToString();
                        test.ToString();
                        break;
                    case 7:
                        Console.WriteLine("Bye-bye...");
                        Console.ReadKey();
                        break;
                }
            } while (checker != 7);
        }

    }

}
