using HeicConverter.Functions;

namespace HeicConverter
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            TopPanel.MouseDown += External.MoveForm;
        }

        
    }
}
