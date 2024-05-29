namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisteme xosh gelmisiniz");
            Console.WriteLine("Ad daxil edin");
            string name = Console.ReadLine();
            int stringLength = name.Length;
            if (stringLength > 2 && stringLength < 20)
            {

                if (CheckName(name) == -1)
                {
                    Console.WriteLine("ilk herf boyuk herf deyil");
                }
                else if (CheckName(name) == -0)
                {
                    Console.WriteLine("ad duzgun deyil");
                }
                else
                {
                    Console.WriteLine("Soyadi daxil edin");
                    string surname = Console.ReadLine();
                    stringLength = surname.Length;
                    if (stringLength > 2 && stringLength < 35)
                    {

                        if (CheckName(surname) == -1)
                        {
                            Console.WriteLine("ilk herf boyuk herf deyil");
                        }
                        else if (CheckName(surname) == -0)
                        {
                            Console.WriteLine("ad duzgun deyil");
                        }
                        else
                        {
                            Console.WriteLine("ata adin daxil edin ");
                            string middleName = Console.ReadLine();
                            stringLength = middleName.Length;
                            if (stringLength > 2 && stringLength < 20)
                            {

                                if (CheckName(middleName) == -1)
                                {
                                    Console.WriteLine("ilk herf boyuk herf deyil");
                                }
                                else if (CheckName(middleName) == -0)
                                {
                                    Console.WriteLine("ad duzgun deyil");
                                }
                                else
                                {
                                    Console.WriteLine("yashi daxil edin");
                                    int age=int.Parse(Console.ReadLine());
                                    if(age>=18 && age <= 65){
                                        Console.WriteLine("fin daxil edin");
                                    }
                                    else
                                    {
                                        Console.WriteLine("yash dogru deyil");
                                    }

                                }
                            }
                        }
                    }
                    else
                    {

                        Console.WriteLine("uzunluq dogru deyil");

                    }
                }
            }
        }
        private static int CheckName(string s) {
            int stringLength = s.Length;
            if (s[0]<65 || s[0] > 90)
                {
                    return -1;
                }
               

                for (int i = 0; i < stringLength; i++)
                {
                    if ((s[i]>=65 &&s[i]<=90) || s[i]>=95 && s[i] <= 122)
                    {
                        continue;
                    }
                    return 0;
                }
                return 1;
                
            }
            
        
    }
}