using System.IO;

class Program {
    static void Main(string[] args) {
        TextWriter output = new StreamWriter("views.txt", true);
        output.WriteLine("Views: 0"); 
        output.Close();
        output.Dispose();
        output = new StreamWriter("views.txt", true);
        int views = 0;
        output.WriteLine("Views: " + views);
        output.Close();
        output.Dispose();
        View.Dispose();
    }
}
