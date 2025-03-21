namespace Core
{
    public class dataProcessor {
        private string _data;
        
        public void process(string input) {
            var x = 5;
            if(x==5)
            {
                _data=input;
            }
        }

        public string getData() {
            return _data;
        }
    }
}