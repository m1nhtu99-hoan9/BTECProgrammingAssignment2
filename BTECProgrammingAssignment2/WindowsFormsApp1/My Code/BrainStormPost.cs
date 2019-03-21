using System;

namespace WindowsFormsApp1
{
    public class BrainStormPost : IComparable<BrainStormPost>
    {
        private string idea;
        private int numVote;

        public BrainStormPost(string _idea)
        {
            this.Idea = _idea;
            this.NumberOfVote = 0;
        }
        public BrainStormPost(string _idea, int _vote)
        {
            this.Idea = _idea;
            this.NumberOfVote = _vote;
        }

        #region Properties
        public string Idea
        {
            get
            {
                return idea;
            }

            set
            {
                idea = value;
            }
        }
        public int NumberOfVote
        {
            get
            {
                return numVote;
            }

            set
            {
                numVote = value;
            }
        }
        #endregion

        public void Vote()
        {
            numVote++;
        }

        // This method is derived from the interface of IComparable<T> where T is class 
        // CompareTo(T other) makes possible comparisions of instances of the same class
        public int CompareTo(BrainStormPost other)
        {
            if (this.NumberOfVote < other.NumberOfVote)
                return 1;
            if (this.NumberOfVote > other.NumberOfVote)
                return -1;
            return 0;
        }
    }
}
