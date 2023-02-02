using Exercise.ContentContext;

namespace Exercise.ContentContext{
    public class Module {
        public Module() {
            lectures = new List<Lecture>();
        }
        public int Order { get; set; }

        public string Title { get; set; }
        public IList<Lecture> lectures {get; set;}
        }   

}
