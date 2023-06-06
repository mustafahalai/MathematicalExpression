using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CC_Project
{
    class Expression
    {

//        Project 6	Mustafa
//Take any mathematic expression from user and then convert it equivalent MASM assembly code.


           public  List<string> assembly = new List<string>();
           public List<string> arr = new List<string>();
           public List<string> temp = new List<string>();

            string var = "";
         

        private void AssemblyValues()
          {
              assembly.Add("+");
              assembly.Add("\nMOV eax,");
              assembly.Add("\nADD eax,");
              assembly.Add("\nADD ebx,");       //from Right precedence


              assembly.Add("-");
              assembly.Add("\nMOV eax,");
              assembly.Add("\nSUB eax,");
              assembly.Add("\nSUB ebx,");      //from Right precedence


              assembly.Add("*");
              assembly.Add("\nMOV eax,");
              assembly.Add("\nMOV ebx,");
              assembly.Add("\nMUL ebx");
              assembly.Add("\nMOV edx,");  //from Right precedence
              assembly.Add("\nMUL edx");

              assembly.Add("/");

              assembly.Add("\nMOV eax,");
              assembly.Add("\nMOV ebx,");
              assembly.Add("\nDIV ebx");
              assembly.Add("\nMOV edx,"); //from Right precedence
              assembly.Add("\nDIV edx");

              assembly.Add("\nMOV eax,edx");
              assembly.Add("\nMUL eax");
              assembly.Add("\nDIV eax");
              assembly.Add("\nADD ebx,edx");
              assembly.Add("\nSUB ebx,edx");
          }

        public string ExpressionCheck(string val)
        {
          //  string exp = "33-2/45*7";
            AssemblyValues();
            string data = val;
            foreach (char item in val)
            {

                if (item == '+')
                {
                    arr.Add(var);
                    arr.Add("+");
                    var = "";

                }
                else
                    if (item == '-')
                    {
                        arr.Add(var);
                        arr.Add("-");
                        var = "";

                    }
                    else
                        if (item == '*')
                        {
                            arr.Add(var);
                            arr.Add("*");
                            var = "";

                        }
                        else
                            if (item == '/')
                            {
                                arr.Add(var);
                                arr.Add("/");
                                var = "";
                            }
                            else
                            {
                                var = var + item;
                            }
            }

            arr.Add(var);
           

                for (int i = 0; i < arr.Count; i++)
                {
                    temp.Add(arr[i]);
                }

                val = "";
                string substring1 = "";
                string substring2 = "";
                string substring3 = "";
                if (arr.Count == 3)
                {
                    substring1 = data.Substring(0, data.Length);
                    substring2 = "";
                }
                else if (arr.Count == 5)
                {
                    if (arr.IndexOf("*") == 1 && data.Contains("/") == false)
                    {
                        substring1 = arr[0] + arr[1] + arr[2];
                        substring2 = arr[3] + arr[4];
                    }
                    else if (arr.IndexOf("*") == 3 && data.Contains("/") == false)
                    {
                        substring1 = arr[0] + arr[1];
                        substring2 = arr[2] + arr[3] + arr[4];
                    }
                    else if (arr.IndexOf("/") == 1 && data.Contains("*") == false)
                    {
                        substring1 = arr[0] + arr[1] + arr[2];
                        substring2 = arr[3] + arr[4];
                    }
                    else if (arr.IndexOf("/") == 3 && data.Contains("*") == false)
                    {
                        substring1 = arr[0] + arr[1];
                        substring2 = arr[2] + arr[3] + arr[4];
                    }
                    else
                    {
                        substring1 = arr[0] + arr[1] + arr[2];
                        substring2 = arr[3] + arr[4];
                    }

                    //if (data.Length == 5)
                    //{
                    //    substring1 = data.Substring(0, 3);
                    //    substring2 = data.Substring(3, 2);
                    //}
                    //if (data.Length == 6)
                    //{
                    //    substring1 = data.Substring(0, 4);
                    //    substring2 = data.Substring(4, 2);
                    //}
                    //if (data.Length == 7)
                    //{
                    //    substring1 = data.Substring(0, 4);
                    //    substring2 = data.Substring(4, data.Length - 4);
                    //    //substring1 = arr[0] + arr[1] + arr[2];
                    //    //substring2 = arr[3] + arr[4];

                    //}
                    //if (data.Length == 8)
                    //{
                    //    substring1 = data.Substring(0, 5);
                    //    substring2 = data.Substring(5, 3);
                    //}
                    //if (data.Length == 9)
                    //{
                    //    substring1 = data.Substring(0, 3);
                    //    substring2 = data.Substring(3, 4);
                    //}


                }
                else
                {
                    if (arr.Count > 5)
                    {
                        substring1 = arr[0] + arr[1] + arr[2];
                        substring2 = arr[4] + arr[5] + arr[6];
                        substring3 = arr[3];
                        //if (arr.IndexOf("*") == 1 || arr.IndexOf("*") == 3 || arr.IndexOf("*") == 5)
                        //{

                        //}
                        //else if (arr.IndexOf("*") == 3)
                        //{
                        //    substring1 = arr[0] + arr[1] + arr[2];
                        //    substring2 =  arr[4] + arr[5]+ arr[6];
                        //    substring3 = arr[3];
                        //}
                        //else if (arr.IndexOf("*") == 5)
                        //{
                        //    substring1 = arr[0] + arr[1] + arr[2];
                        //    substring2 = arr[4] + arr[5] + arr[6];
                        //    substring3 = arr[3];
                        //}
                        //else if (true)
                        //{

                        //}
                        //else if (true)
                        //{

                        //}

                        //substring1 = data.Substring(0, 4);
                        //substring2 = data.Substring(5, data.Length / 2);
                        //substring3 = data.Substring(4, 1);
                    }


                }



                while (temp.Count != 0)
                {
                    //if (temp.Count != 0)
                    //{
                    //    //  temp[i] == assembly[i2] && arr.IndexOf("*") > 2 || temp[i] == assembly[i2] && arr.IndexOf("*") < 2
                    // temp[i] == assembly[i2] && arr.IndexOf("/") > 2 || temp[i] == assembly[i2] && arr.IndexOf("/") < 2
                    if (substring1.Contains("*") == true && substring1.Contains("/") == false)
                    {
                        val = val + assembly[9] + arr[arr.IndexOf("*") - 1] + assembly[10] + arr[arr.IndexOf("*") + 1] + assembly[11];
                        temp.RemoveAt(temp.IndexOf("*") + 1);
                        temp.RemoveAt(temp.IndexOf("*") - 1);
                        temp.RemoveAt(temp.IndexOf("*"));

                        substring1 = "";

                    }
                    if (substring1.Contains("/") == true && substring1.Contains("*") == false)
                    {
                        val = val + assembly[15] + arr[arr.IndexOf("/") - 1] + assembly[16] + arr[arr.IndexOf("/") + 1] + assembly[17];

                        temp.RemoveAt(temp.IndexOf("/") + 1);
                        temp.RemoveAt(temp.IndexOf("/") - 1);
                        temp.RemoveAt(temp.IndexOf("/"));

                        substring1 = "";

                    }
                    if (substring2.Contains("*") == true && substring2.Contains("/") == false)
                    {
                        // if there is + in start
                        if (substring1.Contains("+") || substring1.Contains("-"))
                        {
                            val = val + assembly[9] + arr[arr.IndexOf("*") - 1] + assembly[10] + arr[arr.IndexOf("*") + 1] + assembly[11];

                        }

                        else if (arr.Count > 5)
                        {
                            val = val + assembly[9] + arr[arr.IndexOf("*") - 1] + assembly[12] + arr[arr.IndexOf("*") + 1] + assembly[13];
                        }
                        else
                        {
                            val = val + assembly[12] + arr[arr.LastIndexOf("*") + 1] + assembly[13];

                        }


                        if (temp.IndexOf("*") == 1)
                        {
                            temp.RemoveAt(temp.IndexOf("*") - 1);
                            temp.RemoveAt(temp.IndexOf("*"));
                        }

                        else if (temp.IndexOf("*") == 0 && substring3 == "")
                        {
                            temp.RemoveAt(temp.IndexOf("*") + 1);
                            temp.RemoveAt(temp.IndexOf("*"));
                        }

                        else
                        {
                            temp.RemoveAt(temp.IndexOf("*") - 1);
                            temp.RemoveAt(temp.IndexOf("*") + 1);

                            temp.RemoveAt(temp.LastIndexOf("*"));

                        }
                        substring2 = "";


                    }

                    if (substring2.Contains("/") == true && substring2.Contains("*") == false)
                    {


                        if (substring1.Contains("+") || substring1.Contains("-"))
                        {
                            val = val + assembly[15] + arr[arr.IndexOf("/") - 1] + assembly[16] + arr[arr.IndexOf("/") + 1] + assembly[17];

                        }
                        else if (arr.Count > 5)
                        {
                            val = val + assembly[15] + arr[arr.IndexOf("/") - 1] + assembly[18] + arr[arr.IndexOf("/") + 1] + assembly[19];

                        }

                        else
                        {
                            val = val + assembly[18] + arr[arr.LastIndexOf("/") + 1] + assembly[19];

                        }

                        if (temp.IndexOf("/") == 1)
                        {
                            temp.RemoveAt(temp.IndexOf("/") - 1);
                            temp.RemoveAt(temp.IndexOf("/"));
                        }

                        else if (temp.IndexOf("/") == 0)
                        {
                            temp.RemoveAt(temp.IndexOf("/") + 1);
                            temp.RemoveAt(temp.IndexOf("/"));
                        }
                        else
                        {
                            temp.RemoveAt(temp.IndexOf("/") - 1);
                            temp.RemoveAt(temp.IndexOf("/") + 1);

                            temp.RemoveAt(temp.LastIndexOf("/"));

                        }
                        substring2 = "";


                    }

                    if (substring1.Contains("+") == true && arr.IndexOf("+") < 2)
                    {
                        if (substring2.Contains("*") == true && substring3 == "" || substring2.Contains("/") == true && substring3 == "")
                        {
                            val = val + assembly[3] + arr[arr.IndexOf("+") - 1];
                            temp.RemoveAt(temp.IndexOf("+") - 1);
                            temp.RemoveAt(temp.IndexOf("+"));
                        }
                        else if (arr.IndexOf("*") > 2 && arr.Count == 5 || arr.IndexOf("/") > 2 && arr.Count == 5)
                        {
                            val = val + assembly[3] + arr[arr.IndexOf("+") - 1];
                            temp.RemoveAt(temp.IndexOf("+") - 1);
                            temp.RemoveAt(temp.IndexOf("+"));
                        }
                        else if (arr.IndexOf("*") > 4 && arr.Count == 7 || arr.IndexOf("/") > 4 && arr.Count == 7)
                        {
                            val = val + "\nMOV edx," + arr[arr.IndexOf("+") - 1] + "\nADD edx," + arr[arr.IndexOf("+") + 1];

                            temp.RemoveAt(temp.IndexOf("+") - 1);
                            temp.RemoveAt(temp.IndexOf("+") + 1);
                            temp.RemoveAt(temp.IndexOf("+"));
                        }
                        else
                        {
                            val = val + assembly[1] + arr[arr.IndexOf("+") - 1] + assembly[2] + arr[arr.IndexOf("+") + 1];

                            temp.RemoveAt(temp.IndexOf("+") - 1);
                            temp.RemoveAt(temp.IndexOf("+") + 1);
                            temp.RemoveAt(temp.IndexOf("+"));
                        }

                        substring1 = "";
                    }
                    if (substring2.Contains("+") == true && substring1.Contains("-") == false)
                    {
                        //&& arr.IndexOf("+") > 2
                        if (substring1.Contains("*") || substring1.Contains("/"))
                        {
                            val = val + assembly[3] + arr[arr.IndexOf("+") + 1];
                            temp.RemoveAt(temp.IndexOf("+") + 1);
                            temp.RemoveAt(temp.IndexOf("+"));
                        }
                        //if (arr.IndexOf("+") ==3 && arr.IndexOf("+") == 5)
                        //{
                        //      val = val + assembly[10] + arr[arr.IndexOf("+") - 1] + "\nADD ebx," + arr[arr.IndexOf("+") + 1];

                        //    temp.RemoveAt(temp.IndexOf("+") - 1);
                        //    temp.RemoveAt(temp.IndexOf("+") + 1);
                        //    temp.RemoveAt(temp.IndexOf("+"));
                        //}
                        else if (arr.IndexOf("*") == 3 && arr.Count == 7 || arr.IndexOf("/") == 3 && arr.Count == 7)
                        {
                            val = val + "\nMOV edx," + arr[arr.LastIndexOf("+") - 1] + "\nADD edx," + arr[arr.LastIndexOf("+") + 1];

                            temp.RemoveAt(temp.IndexOf("+") - 1);
                            temp.RemoveAt(temp.IndexOf("+") + 1);
                            temp.RemoveAt(temp.IndexOf("+"));
                        }

                        else
                        {
                            val = val + assembly[2] + arr[arr.LastIndexOf("+") + 1];
                            temp.RemoveAt(temp.IndexOf("+") + 1);
                            temp.RemoveAt(temp.IndexOf("+"));
                        }

                        substring2 = "";


                    }
                    if (substring1.Contains("-") == true && arr.IndexOf("-") < 2)
                    {
                        if (substring2.Contains("*") == true && arr.Count == 5 || substring2.Contains("/") == true && arr.Count == 5)
                        {
                            //|| arr.IndexOf("*") >2 || arr.IndexOf("/") >2
                            val = val + assembly[7] + arr[arr.IndexOf("-") - 1];
                            temp.RemoveAt(temp.IndexOf("-") - 1);
                            temp.RemoveAt(temp.IndexOf("-"));

                        }
                        else if (arr.IndexOf("*") > 4 && arr.Count == 7 || arr.IndexOf("/") > 4 && arr.Count == 7)
                        {
                            val = val + "\nMOV edx," + arr[arr.IndexOf("-") - 1] + "\nSUB edx," + arr[arr.IndexOf("-") + 1];

                            temp.RemoveAt(temp.IndexOf("-") - 1);
                            temp.RemoveAt(temp.IndexOf("-") + 1);
                            temp.RemoveAt(temp.IndexOf("-"));
                        }
                        else
                        {
                            val = val + assembly[5] + arr[arr.IndexOf("-") - 1] + assembly[6] + arr[arr.IndexOf("-") + 1];
                            temp.RemoveAt(temp.IndexOf("-") + 1);
                            temp.RemoveAt(temp.IndexOf("-") - 1);
                            temp.RemoveAt(temp.IndexOf("-"));
                        }

                        substring1 = "";
                    }
                    if (substring2.Contains("-") == true && substring1.Contains("+") == false)
                    {
                        // && arr.IndexOf("-") > 2
                        if (substring1.Contains("*") || substring1.Contains("/"))
                        {
                            val = val + assembly[7] + arr[arr.IndexOf("-") + 1];
                            temp.RemoveAt(temp.IndexOf("-") + 1);
                            temp.RemoveAt(temp.IndexOf("-"));
                        }
                        else if (arr.IndexOf("*") == 3 && arr.Count == 7 || arr.IndexOf("/") == 3 && arr.Count == 7)
                        {
                            val = val + "\nMOV edx," + arr[arr.LastIndexOf("-") - 1] + "\nSUB edx," + arr[arr.LastIndexOf("-") + 1];

                            temp.RemoveAt(temp.IndexOf("-") - 1);
                            temp.RemoveAt(temp.IndexOf("-") + 1);
                            temp.RemoveAt(temp.IndexOf("-"));
                        }
                        else
                        {
                            val = val + assembly[6] + arr[arr.LastIndexOf("-") + 1];
                            temp.RemoveAt(temp.IndexOf("-") + 1);
                            temp.RemoveAt(temp.IndexOf("-"));
                        }

                        substring2 = "";


                    }
                    if (substring3 != "" && substring2 == "")
                    {
                        if (substring3.Contains("*") == true)
                        {
                            if (arr.IndexOf("+") == 5 || arr.IndexOf("-") == 5 || arr.IndexOf("+") == 1 || arr.IndexOf("-") == 1)
                            {
                                val = val + "\nMUL edx";
                                temp.RemoveAt(temp.IndexOf("*"));
                            }
                            else
                            {
                                val = val + assembly[21];
                                temp.RemoveAt(temp.IndexOf("*"));
                            }


                        }
                        if (substring3.Contains("/") == true)
                        {
                            if (arr.IndexOf("+") == 5 || arr.IndexOf("-") == 5 || arr.IndexOf("+") == 1 || arr.IndexOf("-") == 1)
                            {
                                val = val + "\nDIV edx";
                                temp.RemoveAt(temp.IndexOf("/"));
                            }
                            else
                            {
                                val = val + assembly[22];
                                temp.RemoveAt(temp.IndexOf("/"));
                            }

                            //substring3 = "";

                        }

                        if (substring3.Contains("+") == true)
                        {

                            if (temp.Count > 1)
                            {
                                val = val + assembly[2] + arr[arr.LastIndexOf("+") + 1];
                                temp.RemoveAt(temp.IndexOf("+") + 1);
                                temp.RemoveAt(temp.IndexOf("+"));
                            }
                            else
                            {
                                val = val + "\nADD ebx,edx";
                                temp.RemoveAt(temp.IndexOf("+"));
                            }

                            // substring3 = "";
                        }

                        if (substring3.Contains("-") == true)
                        {
                            val = val + assembly[24];
                            temp.RemoveAt(temp.IndexOf("-"));
                        }
                        substring3 = "";
                    }
                }

                arr.Clear();
                assembly.Clear();
                temp.Clear();
                var = "";
                data = "";

                val = val + "\nCALL WriteInt ";
            
            
            return val;

        }


        
        //public string LeftToRight(string val)
        //{
        //    val = "MOV eax," + Check[0];
        //    for (int i = 0; i < Check.Length; i++)
        //    {
        //        if (arr.Length <= 3)
        //        {

        //            // && !data.Contains('*')|| !data.Contains('/')
        //            if (Check[i].ToString() == "+")
        //            {


        //                val = val + "\nADD eax, " + Check[data.IndexOf('+') + 1];

        //                //if (data.IndexOf('-')>=3 )
        //                //{
        //                //    val = val + "\nSUB eax," + Check[data.IndexOf('-')+1];
        //                //}
        //            }
        //            if (Check[i].ToString() == "-")
        //            {
        //                val = val + "\nSUB eax," + Check[data.IndexOf('-') + 1];
        //            }

        //            if (Check[i].ToString() == "*")
        //            {
        //                val = val + "\nMUL," + Check[data.IndexOf('*') + 1];
        //            }

        //            if (Check[i].ToString() == "/")
        //            {
        //                val = val + "\nMOV ebx," + Check[data.IndexOf('/') + 1] + "\nDIV ebx,";

        //                // val = val + "\nDIV ebx," + Check[data.IndexOf('/') + 1];
        //            }
        //        }


        //    }
        //    return val;
            

        
        //}

    }
}
