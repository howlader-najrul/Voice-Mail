using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Speech.Synthesis;
namespace VoiceBasedMail.Web
{
    public partial class Text_To_Speech : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            // creating the object of SpeechSynthesizer class
            SpeechSynthesizer sp = new SpeechSynthesizer();
            //setting volume 
            sp.Volume = 100;
            //passing text box text to SpeakAsync method 
            sp.SpeakAsync(TextBox3.Text);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            // creating the object of SpeechSynthesizer class
            SpeechSynthesizer sp = new SpeechSynthesizer();
            //setting volume 
            sp.Volume = 100;
            //passing text box text to SpeakAsync method 
            sp.SpeakAsync(TextBox2.Text);
        }


        /* Start to message box*/
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            // creating the object of SpeechSynthesizer class
            SpeechSynthesizer sp = new SpeechSynthesizer();
            //setting volume 
            sp.Volume = 100;
            //passing text box text to SpeakAsync method 
            sp.SpeakAsync(TextBox1.Text);
        }
    }
}