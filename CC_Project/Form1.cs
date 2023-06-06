using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Expression expression = new Expression();
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            expression.arr.Clear();
            expression.assembly.Clear();
            expression.temp.Clear();
        }
            //        ; compute the sum

            //mov eax, num2  ; moves num2 to eax
            //add eax, num1  ; adds num2 to num1 
            //mov sum, eax   ; the val is stored in eax
            //        mov eax, sum
            //call WriteInt ; prints the value in eax
        private void Check_Btn_Click(object sender, EventArgs e)
        {
            
            bool onlyExpression = true;
            string expTxtBox = "";

                if (textBox1.Text != "")
                {
                    try
                    {
                       
                        string rejectValue = "`~@#$%^&_=<>|{}[]:;?()";
                        char[] unWantedValue = rejectValue.ToCharArray();
                        char[] test = textBox1.Text.ToCharArray();
                        if (textBox1.Text.IndexOf("**") > -1)
                        {
                            onlyExpression = false;

                        }
                        if (textBox1.Text[(textBox1.Text.Length-1)]=='*')
                        {
                            onlyExpression = false;

                        }
                        if (textBox1.Text[(textBox1.Text.Length - 1)] == '/')
                        {
                            onlyExpression = false;

                        }
                        if (textBox1.Text[(textBox1.Text.Length - 1)] == '+')
                        {
                            onlyExpression = false;

                        }
                        if (textBox1.Text[(textBox1.Text.Length - 1)] == '-')
                        {
                            onlyExpression = false;

                        }
                        if (textBox1.Text.IndexOf("//") > -1)
                        {
                            onlyExpression = false;

                        } if (textBox1.Text.IndexOf("--") > -1)
                        {
                            onlyExpression = false;

                        } if (textBox1.Text.IndexOf("++") > -1)
                        {
                            onlyExpression = false;

                        } if (textBox1.Text.IndexOf("**") > -1)
                        {
                            onlyExpression = false;

                        }
                     
                        for (int i = 0; i < textBox1.TextLength; i++)
                        {
                            for (int j = 0; j < unWantedValue.Length; j++)
                            {
                                if (test[i] == unWantedValue[j])
                                {
                                    onlyExpression = false;
                                   
                                }
                                else if (char.IsLetter(test[i]))
                                {
                                    onlyExpression = false;
                                   
                                }
                          
                                else if (char.IsSeparator(test[i]))
                                {
                                    onlyExpression = false;
                                   
                                }
                                //else if (test[0] == '/' ||test[0] == '*' ||test[0] == '-' ||test[0] == '+'  )
                                //{
                                //    onlyExpression = false;
                                    
                                //}
                                else
                                {
                                    expTxtBox = textBox1.Text;
                                }
                            }

                        }


                        if (onlyExpression == true)
                        {
                            string StartProgram = "\n TITLE Convert Expression to Assembly Code (Expression.asm)\n\nINCLUDE Irvine.inc \n\n.code \n\n main PROC\n\n";
                            string EndProgram = "\n\n\nexit\n\nmain ENDP\n\nEND main";
                            richTextBox1.Text = StartProgram + expression.ExpressionCheck(expTxtBox) + EndProgram;


                            expTxtBox = "";
                        }
                        else
                        {

                            MessageBox.Show("Please Enter Expression Again", "Error..!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                       


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error..!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Enter Expression", "Error..!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 13;
        }
        

    }
}
