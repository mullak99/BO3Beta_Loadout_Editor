using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using BLOPS3;
using System.Reflection;

namespace BlackOps3MultiTool
{
    public partial class Form1 : Form
    {
        private static System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
        private static FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

        public static bool isBetaVersion = false;

        class Typedef // Example with a string "typedef"
        {
            private string Value = "";
            public static implicit operator string (Typedef ts)
            {
                return ((ts == null) ? null : ts.Value);
            }
            public static implicit operator Typedef(string val)
            {
                return new Typedef { Value = val };
            }
        }

        private bool isGameRunning()
        {
            Process[] pname = Process.GetProcessesByName("BlackOps3");

            if (pname.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void gameNotRunning()
        {
            MessageBox.Show("Error: Black Ops 3 not running.", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        public static string version()
        {
            if(isBetaVersion)
            {
                return "v" + fvi.ProductVersion + " BETA";
            }
            else
            {
                return "v" + fvi.ProductVersion;
            }
            
        }
        public static string ProgName = fvi.ProductName;
        public static string copyright = fvi.LegalCopyright;
        public static string trademark = fvi.LegalTrademarks;



        MemoryManipulator memory = new MemoryManipulator("BlackOps3");

        private Int64 ConvertHexToInt(string Hex)
        {
            
            return Int64.Parse(Hex, System.Globalization.NumberStyles.HexNumber);
        }

        private Int32 ConvertHexToInt32(string Hex)
        {

            return Int32.Parse(Hex, System.Globalization.NumberStyles.HexNumber);
        }

        public Form1()
        {
            InitializeComponent();

            if (!memory.CheckProcess())
            {
                //MessageBox.Show("Error: Run the application with administrator priviliges");
            }
            else
            {
                memory.StartProcess();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox7.Visible = false;
            label5.Text = version();
            TickTimer.Start();
            timer1.Start();
            comboBox2.Text = "Class 1";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            if (isGameRunning())
            {

                int Token;
                if (!Int32.TryParse(textBox1.Text, out Token))
                {
                    errorProvider1.SetError(textBox1, "Must be an integer");
                    return;
                }
                else
                {
                    Token = Convert.ToInt32(textBox1.Text);
                }

                if (Token > 256)
                {
                    Token = 256;
                }
                if(Token < 0)
                {
                    Token = 0;
                }
                memory.WriteInt64(ConvertHexToInt(BLOPS3.GLOBAL.Tokens), Token);
            }
            else
            {
                gameNotRunning();
            }
            
        }

        private void toggleDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(groupBox7.Visible == false)
            {
                groupBox7.Visible = true;
            }
            else
            {
                groupBox7.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (groupBox7.Visible == true)
            {
                if (isGameRunning())
                {
                    memory.WriteInt64(ConvertHexToInt(textBox2.Text), Int64.Parse(textBox3.Text));
                }
                else
                {
                    gameNotRunning();
                }

            } 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                ProgName + " " + version() + Environment.NewLine +
                trademark + " | " + copyright, "About"
                );
        }
        bool ToggleHATER = false;

        private void LockHATEROn()
        {
            memory.WriteInt64(ConvertHexToInt(BLOPS3.GLOBAL.HATER), 1);
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                label18.Text = "RUNNING";
                label18.ForeColor = System.Drawing.Color.Green;

                if (ToggleHATER)
                {
                    LockHATEROn();
                }

                if (memory.ReadInt64(ConvertHexToInt(BLOPS3.GLOBAL.HATER)) > 0)
                {
                    label24.Text = "On";
                }
                else
                {
                    label24.Text = "Off";
                }



                memory.StartProcess();
            }
            else
            {
                label18.Text = "STOPPED";
                label18.ForeColor = System.Drawing.Color.Red;
            }

            
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                ToggleHATER = true;
            }
            else
            {
                gameNotRunning();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                ToggleHATER = false;
                memory.WriteInt64(ConvertHexToInt(BLOPS3.GLOBAL.HATER), Convert.ToInt32(false));
            }
            else
            {
                gameNotRunning();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                memory.WriteInt64(ConvertHexToInt(BLOPS3.SPECIALIST.Character), BLOPS3.SPECIALIST.CharacterToInt(comboBox27.Text));
                memory.WriteInt64(ConvertHexToInt(BLOPS3.SPECIALIST.Weapon), BLOPS3.SPECIALIST.WeaponToInt(comboBox28.Text));
            }
            else
            {
                gameNotRunning();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                Int64 Value = memory.ReadInt64(ConvertHexToInt(textBox5.Text));

                textBox4.Text = Value.ToString();
            }
            else
            {
                gameNotRunning();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                if (comboBox2.Text == "Class 1")
                {
                    //Perks
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PerkOne), BLOPS3.PERKS.PerkToInt(PerkOne.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PerkFour), BLOPS3.PERKS.PerkToInt(PerkFour.Text));//

                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PerkTwo), BLOPS3.PERKS.PerkToInt(PerkTwo.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PerkFive), BLOPS3.PERKS.PerkToInt(PerkFive.Text));//

                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PerkThree), BLOPS3.PERKS.PerkToInt(PerkThree.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PerkSix), BLOPS3.PERKS.PerkToInt(PerkSix.Text));
                }
                if (comboBox2.Text == "Class 2")
                {

                    //Perks
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PerkOne), BLOPS3.PERKS.PerkToInt(PerkOne.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PerkFour), BLOPS3.PERKS.PerkToInt(PerkFour.Text));

                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PerkTwo), BLOPS3.PERKS.PerkToInt(PerkTwo.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PerkFive), BLOPS3.PERKS.PerkToInt(PerkFive.Text));

                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PerkThree), BLOPS3.PERKS.PerkToInt(PerkThree.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PerkSix), BLOPS3.PERKS.PerkToInt(PerkSix.Text));
                }
            }
            else
            {
                gameNotRunning();
            }

           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                if (comboBox2.Text == "Class 1")
                {
                    //Primary
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.Primary), BLOPS3.GUN.GunToInt(comboBox1.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PrimaryOptic), BLOPS3.OPTICS.SightToInt(comboBox3.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PrimaryAttach1), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox4.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PrimaryAttach2), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox5.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PrimaryAttach3), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox6.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PrimaryAttach4), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox7.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.PrimaryAttach5), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox8.Text));
                }
                if (comboBox2.Text == "Class 2")
                {
                    //Primary
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.Primary), BLOPS3.GUN.GunToInt(comboBox1.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PrimaryOptic), BLOPS3.OPTICS.SightToInt(comboBox3.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PrimaryAttach1), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox4.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PrimaryAttach2), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox5.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PrimaryAttach3), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox6.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PrimaryAttach4), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox7.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.PrimaryAttach5), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox8.Text));
                }
            }
            else
            {
                gameNotRunning();
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                if (comboBox2.Text == "Class 1")
                {
                    //Secondary
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.Secondary), BLOPS3.GUN.GunToInt(comboBox15.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.SecondaryOptic), BLOPS3.OPTICS.SightToInt(comboBox14.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.SecondaryAttach1), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox13.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.SecondaryAttach2), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox12.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.SecondaryAttach3), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox11.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.SecondaryAttach4), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox10.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.SecondaryAttach5), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox9.Text));
                }
                if (comboBox2.Text == "Class 2")
                {
                    //Secondary
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.Secondary), BLOPS3.GUN.GunToInt(comboBox15.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.SecondaryOptic), BLOPS3.OPTICS.SightToInt(comboBox14.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.SecondaryAttach1), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox13.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.SecondaryAttach2), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox12.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.SecondaryAttach3), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox11.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.SecondaryAttach4), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox10.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.SecondaryAttach5), BLOPS3.ATTACHMENTS.AttachmentToInt(comboBox9.Text));
                }
            }
            else
            {
                gameNotRunning();
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                if (comboBox2.Text == "Class 1")
                {
                    //Grenades
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.Lethal), BLOPS3.LETHAL.LethalToInt(comboBox25.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.Tactical), BLOPS3.TACTICAL.TacticalToInt(comboBox26.Text));

                }
                if (comboBox2.Text == "Class 2")
                {
                    //Grenades
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.Lethal), BLOPS3.LETHAL.LethalToInt(comboBox25.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.Tactical), BLOPS3.TACTICAL.TacticalToInt(comboBox26.Text));

                }
            }
            else
            {
                gameNotRunning();
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                if (comboBox2.Text == "Class 1")
                {
                    //Wildcards
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.WildcardOne), BLOPS3.WILDCARDS.WildcardToInt(comboBox22.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.WildcardTwo), BLOPS3.WILDCARDS.WildcardToInt(comboBox23.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS1.WildcardThree), BLOPS3.WILDCARDS.WildcardToInt(comboBox24.Text));

                }
                if (comboBox2.Text == "Class 2")
                {
                    //Wildcards
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.WildcardOne), BLOPS3.WILDCARDS.WildcardToInt(comboBox22.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.WildcardTwo), BLOPS3.WILDCARDS.WildcardToInt(comboBox23.Text));
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.CLASS2.WildcardThree), BLOPS3.WILDCARDS.WildcardToInt(comboBox24.Text));

                }
            }
            else
            {
                gameNotRunning();
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                if(comboBox30.Text == "Scorestreak 1")
                {
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.SCORESTREAK.Scorestreak1), BLOPS3.SCORESTREAK.StreakToInt(comboBox29.Text));
                }
                if (comboBox30.Text == "Scorestreak 2")
                {
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.SCORESTREAK.Scorestreak2), BLOPS3.SCORESTREAK.StreakToInt(comboBox29.Text));
                }
                if (comboBox30.Text == "Scorestreak 3")
                {
                    memory.WriteInt64(ConvertHexToInt(BLOPS3.SCORESTREAK.Scorestreak3), BLOPS3.SCORESTREAK.StreakToInt(comboBox29.Text));
                }
            }
            else
            {
                gameNotRunning();
            }
        }
    }
}
