using System;

namespace DensityFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            //char Density;
            ////output 
            //Console.WriteLine("if you want to colculate Density enter y");
            ////input
            //Density = Convert.ToChar(Console.ReadLine());

            //if (Density=='y')
            //{
            //    Console.WriteLine("Density Formula");
            //    Console.WriteLine("The density of material shows \n the denseness of it in a specific given area.");
            //    // output
            //    Console.WriteLine("Mass of the body: ");
            //    //input
            //    decimal m = Convert.ToDecimal(Console.ReadLine());

            //    //output
            //    Console.WriteLine("The volume of the body: ");
            //    //input
            //    decimal v = Convert.ToDecimal(Console.ReadLine());

            //    //Equation
            //    decimal p = m / v;
            //    //result output 
            //    Console.WriteLine("Density: " + p + " g/cm3");
            //}
            //else
            //{

            //    //owam
            //    Console.WriteLine("I value  :");
            //    decimal I = Convert.ToDecimal(Console.ReadLine());
            //    Console.WriteLine("R value  :");
            //    decimal R = Convert.ToDecimal(Console.ReadLine());
            //    decimal result = I * R;
            //    Console.WriteLine(" V = " + result);
            //    Console.ReadLine();
            //}

            // operators { = + - / * }
            //// conditation operators { == < > <= >= !=}
            ////Logical operator { && || }

            #region Login
            ////varibales
            //string UserName;
            //string PassWord;
            ////output
            //Console.WriteLine("write your username");
            ////input
            //UserName = Console.ReadLine();

            ////Output 
            //Console.WriteLine("write your password");
            ////input
            //PassWord = Console.ReadLine();

            #region and (logical operator)

            //if (UserName =="Amr" && PassWord =="12345")
            //{
            //    Console.WriteLine("loged in successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Username or password are wrong");
            //}
            #endregion

            #region Or 

            //if (UserName == "Amr" || UserName=="Salah" && PassWord=="123456")
            //{
            //    Console.WriteLine("loged in successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Username or password are wrong");
            //}


            // multi if statement
            //First Condation

            //if (UserName =="Amr" || UserName =="Salah" || UserName=="Soudi")
            //{
            //    //Secound condation
            //    if (PassWord=="12345")
            //    {
            //        Console.WriteLine("loged in successfully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Password is wrong");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Username is wrong");
            //}
            #endregion

            #endregion



            #region Check age
            /////Parameters
            //int AdultsAge = 18;
            //int age;
            ////output
            //Console.WriteLine("what is your age?");
            ////input
            //age = Convert.ToInt32( Console.ReadLine());

            //if (age >= AdultsAge)
            //{
            //    Console.WriteLine("Allowed user");
            //}
            //else
            //{
            //    Console.WriteLine("not allowed user");
            //}
            #endregion

            #region Check sex of user
            //paramters
            //bool take true or false 
            bool sex;
            //output
            Console.WriteLine("are you man ?");
            //input 
            sex = Convert.ToBoolean(Console.ReadLine());

            if (sex != true)
            {
                Console.WriteLine("hi parby");
            }
            else
            {
                Console.WriteLine("hi man!");
            }
            #endregion
            //Console.ReadLine();
            //int age;
            //string last_name;
            //int c;
            //string Email = Console.ReadLine();
            ////age = 20;
            //Console.WriteLine(Email.ToUpper());
            //Console.ReadLine();
        }
    }
}
