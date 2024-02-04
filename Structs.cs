namespace DSA1
{
    public struct Structs
    {

        private string _fname, _lname;

        public Structs(string fname, string lname)
        {
            _fname = fname;
            _lname = lname;
        }

        public string Fname
        {
            get
            {
                return _fname;
            }

            set
            {
                _fname = Fname;
            }
        }

        public string Lname
        {
            get
            {
                return _lname;
            }

            set
            {
                _lname = Lname;
            }
        }

        public override string ToString()
        {
            return $"{_fname} {_lname}";
        }

        public string Initials()
        {
            return $"{_fname.Substring(0, 1)} {_lname.Substring(0, 1)}";
        }
    }
}