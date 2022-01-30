using System.IO;

namespace Training.SrtExtraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOFD_Click(object sender, EventArgs e)
        {
            string myDir = Directory.GetCurrentDirectory();
            string inFile = Path.Combine(myDir, "sub.srt");
            List<string> ans = new();
            using (StreamReader reader = new StreamReader(inFile))
            {
                string p = "";
                while (true)
                {
                    p = reader.ReadLine();
                    if (p == null)
                        break;

                    if (p.StartsWith('('))
                    {
                        ans.Add(p.Substring(1, p.Length - 2));
                    }
                }
            }
            var linq1 = (from a in ans
                         select a).Distinct().ToList();
            string outFile = Path.Combine(myDir, "all_HIs.txt");
            using (StreamWriter wr = new StreamWriter(outFile))
            {
                int count = linq1.Count - 1;
                foreach (var item in linq1)
                {
                    wr.WriteLine($"{linq1.Count - count}.{item}");
                    wr.WriteLine("____");
                    count--;
                }
            }
        }
    }
}