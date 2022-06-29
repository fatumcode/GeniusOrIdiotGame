using GeniyIdiotClassLibrary;


namespace GeniyIdiotWinFormsApp
{
    public partial class previousResultsForm : Form
    {

        public previousResultsForm()
        {
            InitializeComponent();
            Show();

        }


        private void Show()
        {
            try
            {

                var results = UsersResultStorage.GetAll();
                if (results.Count == 0)
                    throw new Exception();
                else
                {
                    foreach (var result in results)
                    {
                        resultsDataGridView.Rows.Add(result.UserName, result.CountRightAnswers, result.FinalDiagnosis);
                    }
                }
            }
            catch (Exception)
            {
                var exceptionMessage = MessageBox.Show("База результатов пуста!", "Внимание!", MessageBoxButtons.OK);
                if (exceptionMessage == DialogResult.OK)
                {
                    return;
                }
            }

        }
    }
}
