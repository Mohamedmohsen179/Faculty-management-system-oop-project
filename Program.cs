using System;
using System.Collections.Generic;
using System.Linq;


namespace oop_project
{
    internal class Program
    {

        static void Main(string[] args)
        { 

        List<Human> usersList = new List<Human>();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine("============================================================================");
                Console.WriteLine("========================Faculty management system ==========================");
                Console.WriteLine("============================================================================");
                Console.WriteLine();


                Console.WriteLine("1) Add user");
                Console.WriteLine("2) Update data of user");
                Console.WriteLine("3) Delete user");
                Console.WriteLine("4) Print all users");
                Console.WriteLine();
                Console.Write("Enter your  Choice : ");
                try
                {
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Clear();


                    if (c == 1)
                    {
                        Console.WriteLine("============================================================================");
                        Console.WriteLine("========================Faculty management system ==========================");
                        Console.WriteLine("============================================================================");
                        Console.WriteLine();
                        Console.WriteLine("                               Add User                                     ");
                        Console.WriteLine();


                        Console.WriteLine("1) Add Student");
                        Console.WriteLine("2) Add Doctor");
                        Console.WriteLine("3) Add Employe");
                        Console.WriteLine();
                        Console.Write("Enter your  Choice : ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (x == 1)
                        {
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("========================Faculty management system ==========================");
                            Console.WriteLine("============================================================================");
                            Console.WriteLine();
                            Console.WriteLine("                                Add Student                                 ");
                            Console.WriteLine();

                            Student user1 = new Student();

                            Console.Write("What is the student name ? ");
                            user1.Set_name(Console.ReadLine());
                            Console.Write("What is the  student id ? ");
                            user1.Set_id(int.Parse(Console.ReadLine()));
                            Console.Write("What is the student Email ? ");
                            user1.Set_Email(Console.ReadLine());
                            Console.Write("What is the student number ? ");
                            user1.Set_phoneNum(int.Parse(Console.ReadLine()));
                            Console.Write("What is the student Level ? ");
                            user1.Set_level(int.Parse(Console.ReadLine()));
                            Console.Write("What is the student gpa ? ");
                            user1.Set_gpa(float.Parse(Console.ReadLine()));
                            usersList.Add(user1);
                            Console.WriteLine();
                            Console.Clear();
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("========================Faculty management system ==========================");
                            Console.WriteLine("============================================================================");
                            Console.WriteLine();
                            Console.WriteLine("                    User information successful Entered                     ");
                            user1.printDetails();
                            Console.WriteLine();

                        }
                        else if (x == 2)
                        {
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("========================Faculty management system ==========================");
                            Console.WriteLine("============================================================================");
                            Console.WriteLine();
                            Console.WriteLine("                                 Add Doctor                                 ");
                            Console.WriteLine();

                            Doctor user1 = new Doctor();
                            Console.Write("What is the doctor name ? ");
                            user1.Set_name(Console.ReadLine());
                            Console.Write("What is the doctor Id ? ");
                            user1.Set_id(int.Parse(Console.ReadLine()));
                            Console.Write("What is the doctor Email ? ");
                            user1.Set_Email(Console.ReadLine());
                            Console.Write("What is the doctor number ? ");
                            user1.Set_phoneNum(int.Parse(Console.ReadLine()));
                            Console.Write("How many doctor courses ? ");
                            user1.Set_courses((int.Parse(Console.ReadLine())));
                            usersList.Add(user1);
                            Console.WriteLine();
                            Console.Clear();
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("========================Faculty management system ==========================");
                            Console.WriteLine("============================================================================");
                            Console.WriteLine();
                            Console.WriteLine("                    User information successful Entered                     ");
                            user1.printDetails();
                            Console.WriteLine();
                        }
                        else if (x == 3)
                        {
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("======================== Faculty management system =========================");
                            Console.WriteLine("============================================================================");
                            Console.WriteLine();
                            Console.WriteLine("                               Add Employee                                 ");
                            Console.WriteLine();
                            Employ user1 = new Employ();

                            Console.Write("What is the Employ name ? ");
                            user1.Set_name(Console.ReadLine());
                            Console.Write("What is the Employ Id ? ");
                            user1.Set_id(int.Parse(Console.ReadLine()));
                            Console.Write("What is the Employ Email ? ");
                            user1.Set_Email(Console.ReadLine());
                            Console.Write("What is the Employ number ? ");
                            user1.Set_phoneNum(int.Parse(Console.ReadLine()));
                            Console.Write("What is the Employ role ? ");
                            user1.Set_role((Console.ReadLine()));
                            Console.Clear();
                            usersList.Add(user1);
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("========================Faculty management system ==========================");
                            Console.WriteLine("============================================================================");
                            Console.WriteLine();
                            Console.WriteLine("                    User information successful Entered                     ");
                            user1.printDetails();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("you Entered Invalid number");
                            Console.WriteLine();
                        }
                    }   

                    else if (c == 2)
                    {
                        try {
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("========================Faculty management system ==========================");
                            Console.WriteLine("============================================================================");
                            Console.WriteLine();
                            Console.WriteLine("                                Update User                                 ");
                            Console.WriteLine();


                            Console.Write("Enter the user's ID : ");
                            int id = int.Parse(Console.ReadLine());
                            Human user = usersList.FirstOrDefault(a => a.Get_id() == id);

                            bool flag = false;

                            if (id != null)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("==========( your Information before updating )========== ");
                                Console.WriteLine();
                                user.printDetails();
                                Console.WriteLine();
                                Console.WriteLine("==============================");
                                Console.WriteLine();
                                Console.WriteLine("What do you want to edit ?");
                                Console.WriteLine("1) Edit name");
                                Console.WriteLine("2) Edit Email");
                                Console.WriteLine("3) Edit number");
                                Console.WriteLine("4) Edit Id");

                                Console.WriteLine("\n");
                                Console.Write("==> The Detail you wanna Edit is : ");
                                int editChoice = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.Clear();

                                if (editChoice == 1)
                                {
                                    Console.WriteLine("============================================================================");
                                    Console.WriteLine("========================Faculty management system ==========================");
                                    Console.WriteLine("============================================================================");
                                    Console.WriteLine();
                                    Console.WriteLine("                                Update Name                                 ");
                                    Console.WriteLine();

                                    Console.Write("Enter ypur new name : ");
                                    user.Set_name(Console.ReadLine());
                                    flag = true;
                                }
                                else if (editChoice == 2)
                                {
                                    Console.WriteLine("============================================================================");
                                    Console.WriteLine("========================Faculty management system ==========================");
                                    Console.WriteLine("============================================================================");
                                    Console.WriteLine();
                                    Console.WriteLine("                               Update Email                                 ");
                                    Console.WriteLine();

                                    Console.Write("Enter your new Email : ");
                                    user.Set_Email(Console.ReadLine());
                                    flag = true;
                                }
                                else if (editChoice == 3)
                                {
                                    Console.WriteLine("============================================================================");
                                    Console.WriteLine("========================Faculty management system ==========================");
                                    Console.WriteLine("============================================================================");
                                    Console.WriteLine();
                                    Console.WriteLine("                              Update number                                 ");
                                    Console.WriteLine();

                                    Console.Write("Enter your new number :");
                                    user.Set_phoneNum(int.Parse(Console.ReadLine()));
                                    flag = true;
                                }
                                else if (editChoice == 4)
                                {
                                    Console.WriteLine("============================================================================");
                                    Console.WriteLine("========================Faculty management system ==========================");
                                    Console.WriteLine("============================================================================");
                                    Console.WriteLine();
                                    Console.WriteLine("                                   Update Id                                ");
                                    Console.WriteLine();

                                    Console.Write("Enter ur new Id :");
                                    user.Set_id(int.Parse(Console.ReadLine()));
                                    flag = true;
                                }
                                Console.WriteLine("\n");
                                Console.Clear();
                                Console.WriteLine("============================================================================");
                                Console.WriteLine("========================Faculty management system ==========================");
                                Console.WriteLine("============================================================================");
                                Console.WriteLine();
                                Console.WriteLine("                     your Information after updating                        ");
                                Console.WriteLine();
                                user.printDetails();
                                Console.WriteLine("\n");
                            }
                            else
                            {
                                Console.WriteLine("you Entered an Invalid Id");
                                Console.ReadKey();
                            }

                        }
                        catch {
                            Console.Clear();
                            Console.WriteLine("you Entered an Invalid number");
                            Console.WriteLine();
                        }
                    }

                    else if (c == 3)
                    {
                        try
                        {
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("========================Faculty management system ==========================");
                            Console.WriteLine("============================================================================");
                            Console.WriteLine();
                            Console.WriteLine("                                Delete user                                 ");
                            Console.WriteLine();

                            Console.Write("Enter the user's id : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("\n");
                            Human user = usersList.FirstOrDefault(a => a.Get_id() == id);

                            Console.WriteLine("Are u Sure u want to remove '" + user.Get_id() + "' ?");
                            Console.Write("If yes plz write 'Y' || If no just write 'N' :  ");
                            char checkRemoving = char.Parse(Console.ReadLine());
                            if (checkRemoving == 'Y' || checkRemoving == 'y')
                            {
                                usersList.Remove(user);
                                Console.WriteLine();

                                Console.WriteLine("User Removed Successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Ok , Nothing Happend ");
                            }


                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("you Entered an Invalid number");
                            Console.ReadKey();

                        }
                    }


                    else if (c == 4)
                    {
                        Console.WriteLine("============================================================================");
                        Console.WriteLine("========================Faculty management system ==========================");
                        Console.WriteLine("============================================================================");
                        Console.WriteLine();
                        Console.WriteLine("                             PRINT ALL USERS                                ");
                        Console.WriteLine();

                        foreach (Human user in usersList)
                        {
                            Console.WriteLine("User " + (usersList.IndexOf(user) + 1));
                            user.printDetails();
                            Console.WriteLine();
                            Console.WriteLine("----------");
                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you Entered an Invalid number");
                        Console.ReadKey();
                    }
                    
                    Console.WriteLine("Do you Wanna try any thing else ?");

                    try
                    {
                        Console.Write("Press Y Or  Enter to continue or press anything else to exit : ");
                        char tryying = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (tryying == 'Y' || tryying == 'y')
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Thanks, See You Soon.");
                            break;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                    }
                }

                catch
                {
                    Console.Clear();
                }
            }   
        }
    }
}
