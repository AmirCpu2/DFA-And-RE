using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enter_DFA_Machine
{
    public partial class Form1 : Form
    {
        public bool IsNotDFA { get; private set; }

        //ABN.NAJAF@GMAIL.COM
        //ابوالفضل نجف زاده

        //ماشین DFA
        //الفبا =={a,b}


        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            ///سه شرط داشتیم برای 
            ///DFA
            /// بودن که عبارتند از :
            /// 1- از هر وضعیت فقط یک حرف از الفبا خارج شود
            /// 2- تمام حروف الفبا برای هر وضعیت باید مشخص شوند
            /// 3- یک انتقال نمیتواند لاندا باشد

            /// که این سه شرط را در پایین بررسی میکنیم


            try
            {
                if (Gv1.Rows[e.RowIndex].Cells[0].Value == null &&
                    Gv1.Rows[e.RowIndex].Cells[1].Value == null &&
                    Gv1.Rows[e.RowIndex].Cells[2].Value == null)
                {
                    Gv1.Rows[e.RowIndex].ErrorText = "";
                    IsNotDFA = false;
                    return;
                }

                ////////////////شرط اول و دوم //////////////////////
                ///این قسمت چک میکند که مقادیر ورودی فقط عدد باشند
                /// و نمیتواند برای یکی از وضعیت های لاندا قرار گیرد
                int numQ = Int32.Parse(Gv1.Rows[e.RowIndex].Cells[0].Value.ToString());
                int numA = Int32.Parse(Gv1.Rows[e.RowIndex].Cells[1].Value.ToString());
                int numB = Int32.Parse(Gv1.Rows[e.RowIndex].Cells[2].Value.ToString());
                ////////////////////////////////////
                Gv1.Rows[e.RowIndex].ErrorText = "";
                IsNotDFA = false;




                ////////////////شرط سوم //////////////////////
                ///که چک میکند هر یک از وضعیت ها فقط یک بار تکرار شده باشند
                /// وضعیت ها == SATE
                for (int i = 0; i < Gv1.Rows.Count - 1; i++)
                {
                    if (Gv1.Rows[e.RowIndex].Cells[0].Value.Equals(Gv1.Rows[i].Cells[0].Value) &&
                        !Gv1.Rows[e.RowIndex].Index.Equals(Gv1.Rows[i].Index))
                    {
                        Gv1.Rows[e.RowIndex].ErrorText = "وضعیت وارد شده تکراری است";
                        IsNotDFA = true;
                        continue;
                    }
                }
            }
            catch (Exception ee)
            {
                Gv1.Rows[e.RowIndex].ErrorText = "داده های ورودی صحیح نیست";
                IsNotDFA = true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Gv1.RowCount <= 1)
                {
                    MessageBox.Show("Is Not DFA! ! No Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Sorted
                DataGridViewColumn gvc = Gv1.Columns[0] as DataGridViewColumn;
                Gv1.Sort(gvc, ListSortDirection.Ascending);
                //End Sorted




                //این حالتی را بررسی میکند که از یک وضعیت به یک وضعیت دیگه ای رفتیم که وضعیت مقصد برایش 
                //a , b
                // مشخص نشده است.
                string StateA, StateB;
                bool IsExistA = false;
                bool IsExistB = false;
                for (int i = 0; i < Gv1.RowCount - 1; i++)
                {
                    StateA = Gv1.Rows[i].Cells[1].Value.ToString();
                    StateB = Gv1.Rows[i].Cells[2].Value.ToString();

                    for (int j = 0; j < Gv1.RowCount - 1; j++)
                    {
                        if (Gv1.Rows[j].Cells[0].Value.Equals(StateA))
                        {
                            IsExistA = true;
                        }
                        if (Gv1.Rows[j].Cells[0].Value.Equals(StateB))
                        {
                            IsExistB = true;
                        }
                    }
                    if (!IsExistA)
                    {
                        Gv1.Rows[i].Cells[1].ErrorText = "Not Find in State";
                    }
                    else
                    {
                        Gv1.Rows[i].Cells[1].ErrorText = "";
                    }


                    if (!IsExistB)
                    {
                        Gv1.Rows[i].Cells[2].ErrorText = "Not Find in State";
                    }
                    else
                    {
                        Gv1.Rows[i].Cells[2].ErrorText = "";
                    }
                    IsExistA = IsExistB = false;
                }






                //این حلقه اگر قبلا خطایی اعلام شده بود که رفع نشده باشد را مشخص میکند
                foreach (DataGridViewRow item in Gv1.Rows)
                {
                    if (!item.ErrorText.Equals("") ||
                        !item.Cells[1].ErrorText.Equals("") ||
                        !item.Cells[2].ErrorText.Equals(""))
                    {
                        MessageBox.Show("Not DFA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }





                if (ReadString())
                {
                    MessageBox.Show("Accepted", "Accept", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rejected", "Reject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Not DFA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean ReadString()
        {
            try
            {
                String Str = txtString.Text.Trim();
                //در این حلقه ما چک میکنیم فقط حروف الفبا ما وارد شده باشد
                //الفبا a , b
                foreach (Char item in Str.ToCharArray())
                {
                    if (!(item.Equals('a') || item.Equals('b')))
                    {
                        MessageBox.Show("حروف ورودی عضو الفیای ما نمی باشند", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }





                //یافتن حالت های پایانی
                List<String> FinalState = new List<string>();
                for (int i = 0; i < Gv1.RowCount - 1; i++)
                {
                    if (Gv1.Rows[i].Cells[3].Value != null && Gv1.Rows[i].Cells[3].Value.Equals(true))
                    {
                        FinalState.Add(Gv1.Rows[i].Cells[0].Value.ToString());
                    }
                }






                String currentState = Gv1.Rows[0].Cells[0].Value.ToString();

                foreach (Char item in Str.ToCharArray())
                {
                    //این حلقه برای این است که اندیس سطر حالت فعلی را بدست آوریم
                    int IndexCurrentRow = 0;
                    foreach (DataGridViewRow GvrItem in Gv1.Rows)
                    {
                        if (GvrItem.Cells[0].Value.Equals(currentState))
                        {
                            IndexCurrentRow = GvrItem.Index;
                            break;
                        }
                    }


                    switch (item)
                    {
                        case 'a':
                            {
                                currentState = Gv1.Rows[IndexCurrentRow].Cells[1].Value.ToString();
                            }; break;
                        case 'b':
                            {
                                currentState = Gv1.Rows[IndexCurrentRow].Cells[2].Value.ToString();

                            }; break;
                    }
                }


                //بررسی این که آیا با خواندن رشته در حالت پایانی متوقف شده ایم 
                if (FinalState.IndexOf(currentState) >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ee)
            {
                return false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Gv1.Rows.Clear();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", System.IO.Directory.GetCurrentDirectory() + "\\Help.pdf");
            }
            catch (Exception ee) { }
        }
    }
}
