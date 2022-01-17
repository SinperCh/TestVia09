namespace wap;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        AddUI();
    }
    void AddUI(){
       TableLayoutPanel panel=new  TableLayoutPanel();
       panel.Dock=DockStyle.Fill;
       panel.ColumnCount=5;
       panel.RowCount=2;
       
       float width=100f/panel.ColumnCount;
       float height=100f/panel.RowCount;

       for(int i=0;i<panel.ColumnCount;i++){
          panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,width));
       }
       for(int j=0;j<panel.RowCount;j++){
          panel.RowStyles.Add(new RowStyle(SizeType.Percent,height));
       }

       for(int i=0;i<panel.RowCount;i++){
           for(int j=0;i<panel.ColumnCount;j++){
               Label lbl=new Label();
               lbl.Dock=DockStyle.Fill;
               lbl.AutoSize=false;
               lbl.Text="test";
               panel.Controls.Add(lbl,j,i);
           }
       }
       this.Controls.Add(panel);
    }
}
