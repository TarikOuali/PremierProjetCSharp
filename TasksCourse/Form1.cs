namespace TasksCourse
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource CTSource;

        public Form1()
        {
            InitializeComponent();
            CTSource = new CancellationTokenSource();
        }


        private int GetSourceHash(string src)
        {
            Thread.Sleep(5000);
            return src.GetHashCode();
        }

        private Task<int> GetSourceHashAsync(string src, CancellationToken token = default)
        {
            if (token == default)
                token = CancellationToken.None;

            var t = Task.Run(() =>
            {
                var i = 5;
                while (!token.IsCancellationRequested && i > 0)
                {
                    Thread.Sleep(1000);
                    i--;
                }
                return src.GetHashCode();
            });
            return t;
        }

        //private Task<int> GetSourceHashAsync2(string src)
        //    => Task.Run(() =>
        //    {
        //        Thread.Sleep(5000);
        //        return src.GetHashCode();
        //    });


        private int GetValue2() => 0;

        //private async Task<IEnumerable<string>> GetDataAsync()
        //{
        //    return await plugin.GetDataAsync();
        //}

        //private async Task<IEnumerable<string>> GetData2Async()
        //{
        //    return await Task.Run(() => plugin.GetData());
        //}




        private async void addBtn_Click(object sender, EventArgs e)
        {
            var src = srcText.Text;
            if (string.IsNullOrEmpty(src))
            {
                return;
            }

            //var task = GetSourceHashAsync(src);
            //var _hash = await task;

            if (CTSource.IsCancellationRequested)
                CTSource = new CancellationTokenSource();

            var _hash = await GetSourceHashAsync(src, CTSource.Token);

            if (!resultLstbox.Items.Contains(_hash))
                resultLstbox.Items.Add(_hash);

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CTSource.Cancel();
        }
    }
}