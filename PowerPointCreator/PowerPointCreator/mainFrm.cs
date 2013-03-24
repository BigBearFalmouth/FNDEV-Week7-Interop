using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

namespace PowerPointCreator
{
    public partial class mainFrm : Form
    {
        //the power point interop object
        Microsoft.Office.Interop.PowerPoint.Application powerPointApplication;
        //the presentation we are working on
        Presentation currentPresentation;
        //the current slide index
        int currentSlideIndex;

        public mainFrm()
        {
            InitializeComponent();
            //slide indicies start at 1, NOT 0!!
            currentSlideIndex = 1;
        }

        private void createPresentationBtn_Click(object sender, EventArgs e)
        {
            //create the powerpoint interop object
            powerPointApplication = new Microsoft.Office.Interop.PowerPoint.Application();
            //set to visible to show powerpoint during this process
            powerPointApplication.Visible = MsoTriState.msoTrue;
            //Get the list of presentations in the application
            Presentations presentations=powerPointApplication.Presentations;
            //add a presentation and add to the list above
            currentPresentation = presentations.Add(MsoTriState.msoCTrue);
        }

        private void createTitleSlideBtn_Click(object sender, EventArgs e)
        {
            //if we have a current presentation
            if (currentPresentation!=null)
            {
                //add a new title slide
                currentPresentation.Slides.Add(currentSlideIndex, PpSlideLayout.ppLayoutTitle);
                currentSlideIndex++;
            }
        }

        private void addTextSlideBtn_Click(object sender, EventArgs e)
        {
            //if we have a current presentation
            if (currentPresentation != null)
            {
                //add a slide with a title and some text
                currentPresentation.Slides.Add(currentSlideIndex, PpSlideLayout.ppLayoutText);
                currentSlideIndex++;
            }
        }

        private void addPicSlideBtn_Click(object sender, EventArgs e)
        {
            //if we have a current presentation
            if (currentPresentation != null)
            {
                //add a slide with an object where we can place a picture
                currentPresentation.Slides.Add(currentSlideIndex, PpSlideLayout.ppLayoutObject);
                currentSlideIndex++;
            }
        }

        private void savePresentationBtn_Click(object sender, EventArgs e)
        {
            //if we have a current presentation
            if (currentPresentation != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //save the presentation in 2003 format
                    currentPresentation.SaveAs(saveFileDialog.FileName, 
                        PpSaveAsFileType.ppSaveAsPresentation, MsoTriState.msoFalse);
                }
            }
        }

    }
}
