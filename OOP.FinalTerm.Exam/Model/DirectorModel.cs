namespace OOP.FinalTerm.Exam.Model
{
    
    //Inherit PersonModel
    //PersonModel must be created first if not already present
    public class DirectorModel : PersonModel
    {
        
        public int TotalMoviesCreated { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Genres { get; set; }
        //add properties here
        //refer to README.md for property details
        //refer to MovieModel for guidance
    }
}
