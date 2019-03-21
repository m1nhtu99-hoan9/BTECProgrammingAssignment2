using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class EntryForm : Form
    {
        // declare a list for sorting independent of BindingSrc 
        List<BrainStormPost> listOfPosts = new List<BrainStormPost>(); 

        public EntryForm()
        {
            InitializeComponent();
            // Add control for DgdDisplay to add Control Handler later
            Controls.Add(DgdDisplay);
        }

        public void EntryForm_Load(object sender, EventArgs e)
        {
            // Visual C# doesn't support InputBox, this feature is imported from Visual Basic
            string title = Interaction.InputBox("Name you BrainStorm board", "Brain Storm Board");
            // Update the EntryForm's Text
            title = ": "+ title;
            this.Text += title;

            // VoteDgdViewBtnCol.Text = "Vote This";
            VoteDgdViewBtnCol.UseColumnTextForButtonValue = true; //without this the button's text won't be displayed 

            // Add a CellClick handler to create event of clicking "Vote This" buttons 
            DgdDisplay.CellClick += new DataGridViewCellEventHandler(dgdDisplay_CellClick);
        }

        private void txtIdea_Click(object sender, EventArgs e)
        {
            txtIdea.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string inp = txtIdea.Text.ToString();
            // <explanation> to avoid addition of empty posts
            if (inp != "")
            {
                listOfPosts.Add(new BrainStormPost(inp));
                BindingSrc.Add(new BrainStormPost(inp));
            }
            // </explanation> 
        }

        private void txtIdea_KeyDown(object sender, KeyEventArgs e)
        {
            // <explanation> When hit enter, call btnAdd_Click Event 
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(this, new EventArgs());
            }
            // </explanation> 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdea.Clear();
        }

        private void dgdDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // <explanation> Ignore clicking outside of cells not needed
            if (e.RowIndex < 0 || e.ColumnIndex != 2)
            {
                return; 
            } // </explanation>
            else
            {
                BrainStormPost thisPost = listOfPosts[e.RowIndex];
                thisPost.Vote();

                DataGridViewCell thisCell = DgdDisplay.Rows[e.RowIndex].Cells["numVoteDgdViewTxtCol"];
                thisCell.Value = thisPost.NumberOfVote;
            }
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // <explanation> Sort listOfPosts to use as data source for new DataGridView displaying Final Result  
            listOfPosts.Sort(); 

            Form FormShowData = new Form();
            FormShowData.Text = "Final Result:";
            DataGridView DgdShow = new DataGridView();
            DgdShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | 
                System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom)));
            DgdShow.Dock = DockStyle.Fill;

            DgdShow.DataSource = listOfPosts;
            // </explanation>

            FormShowData.Show();
            FormShowData.Controls.Add(DgdShow);
        }
    }
}
